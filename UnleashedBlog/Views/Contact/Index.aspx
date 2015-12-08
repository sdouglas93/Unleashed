<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>
<%@Register TagPrefix="scott" TagName="header" Src="NewForm.ascx"  %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id= "form1" runat="server">
        <scott:header
        ID="MyHeader" 
        runat="server" 
        /> 
    </form>
</body>
</html>
