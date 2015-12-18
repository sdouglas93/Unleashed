<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<UnleashedBlog.Paging.PagedList<UnleashedBlog.Models.BlogEntry>>" %>

<% foreach (var entry in Model)
   { %>
    <% Html.RenderPartial("BlogEntry",entry); %>
   
<% } %>


