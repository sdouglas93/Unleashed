<%--<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<UnleashedBlog.Paging.PagedList<UnleashedBlog.Models.BlogEntry>>" %>

<%foreach (var entry in Model)
  {  %>
  <div class = "blogContainer">
   <h1 class="blogEntryTitle"><%= Html.BlogLink(entry) %></h1>
<%--   <h2 class = "blogEntryDatePublished"><%= entry.DatePublished.ToString ("D") %></h2>--%>
    <%--<div class="blogEntryText">
    <%= entry.Text %>
    </div>--%>
   <%-- <div class="blogEntryFooter">
    Posted by <%= entry.Author %> at <%= entry.DatePublished.ToString("d") %>
    </div>
     <div id="styleLine"></div>
  
  </div>

  <% } %>

  <div id="pager">
  <%= Html.BlogPager(Model) %>
  </div>--%>

  <%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<UnleashedBlog.Models.BlogEntry>" %>


<div class="blogEntryContainer">

    <h2 class="blogEntryDatePublished"><%= Model.DatePublished.ToString("D") %></h2>
    <h3 class="blogEntryTitle"><%= Html.BlogLink(Model) %></h3>

    <div class="blogEntryText">
        <%= Model.Text %>
    </div>

    <div class="blogEntryFooter">
        Posted by <%= Model.Author %> at <%= Model.DatePublished.ToString("t") %>
        with <%= Model.CommentCount %> comments.
    </div>
    <div id="styleLine"></div>



</div>