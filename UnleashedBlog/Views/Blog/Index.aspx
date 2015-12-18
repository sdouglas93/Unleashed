<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master"
Inherits="System.Web.Mvc.ViewPage<UnleashedBlog.Paging.PagedList<UnleashedBlog.Models.BlogEntry>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
Index
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div class= "blogLineContainer">
            <div id="styleLine"></div>
                </div>
<% Html.RenderPartial("BlogEntries"); %>


<%--<div id="pager">
  <%= Html.BlogPager(Model) %>
  </div>--%>
</asp:Content>


