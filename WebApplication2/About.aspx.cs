using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class About : Page
    {
        public string otp;
        protected void Page_Load(object sender, EventArgs e)
        {
            otp = "";
            string video_id = "VIDEO_ID";          // This should be obtained from DB
            // The API Secret should not be hard-coded inside the application
            string api_secret = "API_SECRET_KEY"; ;
            string uri = "https://api.vdocipher.com/v2/otp/?video=" + video_id;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            using (StreamWriter writer = new StreamWriter(request.GetRequestStream(), Encoding.ASCII))
            {
                writer.Write("clientSecretKey=" + api_secret);
            }
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            dynamic otp_data;
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                string json_otp = reader.ReadToEnd();
                otp_data = JObject.Parse(json_otp);
                otp = otp_data.otp;
            }
        }
    }
}