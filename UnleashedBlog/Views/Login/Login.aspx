<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<UnleashedBlog.Models.LoginAccount>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Login
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Login</h2>
  

<% using (Html.BeginForm())
   {%>
 
<table width="25%" style="border: 1 solid back; border-collapse: collapse;" border="1" cellpadding="5" cellspacing="5">
    <tr>
        <td colspan="2" style="background-color: Gray;">LOGIN
        </td>
    </tr>
    <tr>
        <td align="right"> User Name:</td>
        <td align="left"><%: Html.TextBoxFor(m => m.UserName, new { @id = "txtuserid", style="width:200px !important;" })%></td>
    </tr>
    <tr>
        <td align="right">Password:</td>
        <td align="left"><%: Html.PasswordFor(m => m.Password, new { @id = "txtpasword", style = "width:200px !important;" })%> </td>
    </tr>
    <tr>
        <td align="center" colspan="2">
            <input type="submit" value="Login" />
        </td>
    </tr>
</table>
    <%--if (ViewBag.Message == 1)
    {
    <script type="text/javascript" language="javascript">
        alert("Successfull login.");
    </script>
    }
    if (ViewBag.Message == 0)
    {
    <script type="text/javascript" language="javascript">
        alert("Please provide correct userid or password.");
    </script>
    }--%>
<% } %>

</asp:Content>
