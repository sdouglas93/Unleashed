
<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<UnleashedBlog.Models.BlogEntry>"  %>
<%--Inherits="System.Web.Mvc.ViewPage<UnleashedBlog.Models.BlogEntry>" %>--%>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 
<%-- --%> <% Html.RenderPartial("BlogEntry"); %> 
 
 <div class ="detailsPage">  
    <div class="commentsContainer">
    <% if (Model != null)
    { %>

    <% foreach (var comment in Model.Comments)
       {  %>
        <div class="commentContainer">
        <h3><%= Html.Encode( comment.Title ) %></h3>
        <div class="commentHeader">
        Posted by <%= Html.NameLink(comment) %>
        on <%= comment.DatePublished.ToString("d") %>
        </div>
        <div class="commentText">
            <%= Html.Encode( comment.Text ) %>
        </div>
        </div>
    <% } %>
    <% } %>
    </div>


    <%--<div class= "comments">
    <fieldset>
    <h2>Add Your Comment</h2>
    <%= Html.ValidationSummary("Create was unsuccessful. Please correct the errors and try again.") %>

    <% using (Html.BeginForm("Create", "Comment", FormMethod.Post, new { @class = "form-horizontal", @role = "form" })) 
       { %>
       <%= Html.Hidden("Comment.BlogEntryId", Model.id)%>
        
               
            <label for="Comment.Title" class="col-sm-1 control-label">Title:</label> 
            <%= Html.TextBox("Comment.Title", "RE: " + Model.Title, new { @class = "form-control" })%>  

            <label for="Comment.Name" class="col-sm-1 control-label">Name:</label>
            <%= Html.TextBox("Comment.Name", "", new { @class = "form-control" })%>  
                 
            <label class="col-sm-1 control-label" for="Comment.Email">Email:</label>
            <%= Html.TextBox("Comment.Email", "", new { @class = "form-control" })%>  
     
            <label class="col-sm-1 control-label" for="Url">URL:</label>
            <%= Html.TextBox("Comment.Url", string.Empty, new { size = 50, @class = "form-control" })%>  
            <%= Html.ValidationMessage("Comment.Url", "*")%>
        
        <div class="textArea">
            <label class="col-sm-1 control-label" for="Comment.Text">Comment:</label>
            <div class="col-sm-6">
            <%= Html.TextArea("Comment.Text", "", new {@class = "form-control", cols = "20", rows = "5" })%>  
        </div>
        </div>

        <div>
            <input type="submit" class="btn btn-warning" value="Add Comment" />
        </div>
    <% } %>
    </fieldset>
  </div>
  </div> 
--%>

  <div class= "comments">
    <fieldset>
    <h2>Add Your Comment</h2>
    <%= Html.ValidationSummary("Create was unsuccessful. Please correct the errors and try again.") %>

    <% using (Html.BeginForm("Create", "Comment", FormMethod.Post, new { @class = "form-horizontal", @role = "form" })) 
       { %>
       <%= Html.Hidden("Comment.BlogEntryId", Model.id)%>
        
          <div class="form-group">       
            <label for="Comment.Title" class="col-sm-2 control-label">Title:</label> 
                <div class="col-sm-10">
            <br /><%= Html.TextBox("Comment.Title", "RE: " + Model.Title, new { @class = "form-control" })%>  
        </div>
        </div>
        
            <div class="form-group">
            <label for="Comment.Name" class="col-sm-2 control-label">Name:</label>
                <div class="col-sm-10">
            <br /><%= Html.TextBox("Comment.Name", "", new { @class = "form-control" })%>  
            </div>
            </div>
     
            
        <div class="form-group">        
            <label class="col-sm-2 control-label" for="Comment.Email">Email:</label>
                <div class="col-sm-10">
            <br /><%= Html.TextBox("Comment.Email", "", new { @class = "form-control" })%>  
        </div>
        </div>

         <div class="form-group">   
            <label class="col-sm-2 control-label" for="Url">URL:</label>
                <div class="col-sm-10">
            <br /><%= Html.TextBox("Comment.Url", string.Empty, new { size = 50, @class = "form-control" })%>  
            <%= Html.ValidationMessage("Comment.Url", "*")%>
        </div>
         </div>

        <div class="form-group"> 
            <label class="col-sm-2 control-label" for="Comment.Text">Comment:</label>
            <div class="col-sm-10">
            <br /><%= Html.TextArea("Comment.Text", "", new {@class = "form-control", cols = "20", rows = "5" })%>  
        </div>
        </div>

        <div>
            <input type="submit" class="btn btn-warning" value="Add Comment" />
        </div>
    <% } %>
    </fieldset>
  </div>
  </div> 
</asp:Content>