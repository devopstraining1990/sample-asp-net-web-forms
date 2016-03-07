<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplication2.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <div id="vdo<%=otp%>" style="height:400px;width:640px;max-width:100%;"></div>
<script>
	(function(v,i,d,e,o){v[o]=v[o]||{}; v[o].add = v[o].add || function V(a){ (v[o].d=v[o].d||[]).push(a);};
	if(!v[o].l) { v[o].l=1*new Date(); a=i.createElement(d), m=i.getElementsByTagName(d)[0];
	a.async=1; a.src=e; m.parentNode.insertBefore(a,m);}
	})(window,document,'script','//de122v0opjemw.cloudfront.net/vdo.js','vdo');
	vdo.add({
	    o: "<%=otp%>",
	});
</script>
</asp:Content>
