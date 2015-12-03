<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<UnleashedBlog.Models.BlogEntry>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Create
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Create</h2>

    <%= Html.ValidationSummary("Create was unsuccessful. Please correct the errors and try again.") %>

    <% using (Html.BeginForm(null, null, FormMethod.Post, new { @class = "form-horizontal", @role = "form" }))
       {%>
   <%--  <form class="form-horizontal" role="form">--%>
        
       
      <%-- <fieldset>--%>
          <%--  <legend>Fields</legend>--%>

          <div class="form-group">
           <label for="Author" class="col-sm-2 control-label">Author:</label>
           <div class="col-sm-10">
                <%= Html.TextBox("Author", " ", new { @class = "form-control" })%>
                <%= Html.ValidationMessage("Author", "*")%>
               
            </div>
            </div>

             <div class="form-group">
              <label class="col-sm-2 control-label" for="Title">Title:</label>
            <div class="col-sm-10">
               
                <%= Html.TextBox("Title", " ", new { @class = "form-control" })%>
                <%= Html.ValidationMessage("Title", "*")%>
             </div>
            </div>

            <div class="form-group">
             <label class="control-label col-sm-2" for="Description">Description:</label>
           <div class="col-sm-10">
               
                <%= Html.TextBox("Description", " ", new { @class = "form-control" })%>
                <%= Html.ValidationMessage("Description", "*")%>
             </div>
                 </div>

             <div class="form-group">
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
          </div>
          <div class="form-group"> 
          <label class="control-label col-sm-2" for="Text">Text:</label>
            <div class="col-sm-10">
                
                <%= Html.TextBox("Text", " ", new { @class = "form-control" })%>
                <%= Html.ValidationMessage("Text", "*")%>
            </div>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        <%--</fieldset>--%>
        <%--</form>--%>
    <% } %>

    <div>
        <%=Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>