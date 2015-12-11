<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<UnleashedBlog.Models.ContactInfo>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Contact Info
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<div id= "formatForm">
<div class="formStyle">
    <h1>Contact Moi</h1>

    <%= Html.ValidationSummary("Create was unsuccessful. Please correct the errors and try again.") %>

    <% using (Html.BeginForm("Contact","Contact", FormMethod.Post, new { @class = "form-horizontal", @role = "form" }))
       {%>
   <%--  <form class="form-horizontal" role="form">--%>
   
       
      <%-- <fieldset>--%>

          <div class="form-group">
           <label for="firstName" class="col-sm-2 control-label">First Name:</label>
           <div class="col-sm-10">
                <%= Html.TextBox("firstName", "", new { @class = "form-control", @id = "firstName" })%>
                <%= Html.ValidationMessage("firstName", "*")%>
               
            </div>
            </div>

             <div class="form-group">
              <label for="lastName" class="col-sm-2 control-label">Last Name:</label>
            <div class="col-sm-10">
               
                <%= Html.TextBox("lastName", "", new { @class = "form-control", @id = "lastName" })%>
                <%= Html.ValidationMessage("lastName", "*")%>
             </div>
            </div>

            <div class="form-group">
             <label for="email" class="control-label col-sm-2">Email:</label>
           <div class="col-sm-10">
               
                <%= Html.TextBox("email", "", new { @class = "form-control", @id = "email" })%>
                <%= Html.ValidationMessage("email", "*")%>
             </div>
                 </div>

            <%-- <div class="form-group">
              <label class="control-label col-sm-2" for="DateModified">DateModified:</label>
            <div class="col-sm-10">
               
                <%= Html.TextBox("DateModified", " ", new { @class = "form-control" })%>
                <%= Html.ValidationMessage("DateModified", "*")%>
             </div>
                 </div>
            
                <div class="form-group">            
                <label class="control-label col-sm-2" for="DatePublished">DatePublished:</label>
                <div class="col-sm-10">
                <%= Html.TextBox("DatePublished", " ", new { @class = "form-control" })%>
                <%= Html.ValidationMessage("DatePublished", "*")%>
            </div>
            </div>

            <div class="form-group">
             <label class="control-label col-sm-2" for="Name">Name:</label> 
            <div class="col-sm-10">
               
                <%= Html.TextBox("Name", " ", new { @class = "form-control" })%>
                <%= Html.ValidationMessage("Name", "*")%>
          </div>
          </div>--%>
          <div class="form-group"> 
          <label for="comment" class="control-label col-sm-2" >Comments:</label>
            <div class="col-sm-10">
                <%= @Html.TextArea("comment", "", new { @class = "form-control",@id = "comment" , rows = "6" })%>
                <%= Html.ValidationMessage("comment", "*")%>
            </div>
            </div>

            <div>
                <input type="submit" class="btn btn-warning" value="Submit" />
            </div>
        <%--</fieldset>--%>
        <%--</form>--%>
    <% } %>
</div>
</div>
   <%-- <div >
        <%=Html.ActionLink("Back to List", "Index") %>
    </div>--%>

</asp:Content>