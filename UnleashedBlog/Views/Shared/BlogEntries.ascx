<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<UnleashedBlog.Paging.PagedList<UnleashedBlog.Models.BlogEntry>>" %>

<%foreach (var entry in Model)
  {  %>
  <div class = "blogContainer">
    <h2 class = "blogEntryDatePublished"><%= entry.DatePublished.ToString ("D") %></h2>
  
    <h3 class="blogEntryTitle"><%= Html.BlogLink(entry) %></h3>
    <div class="blogEntryText">
    <%= entry.Text %>
    </div>
    <div class="blogEntryFooter">

    Posted by <%= entry.Author %> at <%= entry.DatePublished.ToString("t") %>
    </div>
  
  </div>

  <% } %>

  <div id="pager">
  <%= Html.BlogPager(Model) %>
  </div>