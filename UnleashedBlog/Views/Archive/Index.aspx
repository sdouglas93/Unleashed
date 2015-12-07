﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<UnleashedBlog.Models.BlogEntry>>" %>
<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<%--<script type="type/javascript">

jQuery("#jQGridDemo").jqGrid({
  url:'',
  datatype:"json",
  colNames:['DatePublished','DateModified,'Title',
  'Description',' Name','Auhtor','id','Text'],
  colModel:[],
  rowNum:10,
  sortname: 'DatePublished',
  viewrecords: true,
  sortorder:"desc"
  caption: "Le Blog"


});

</script>--%>

    <h2>Index</h2>

    <table>
        <tr>
            <th></th>
            <th>
                DatePublished
            </th>
            <th>
                DateModified
            </th>
            <th>
                Title
            </th>
            <th>
                Description
            </th>
            <th>
                Name
            </th>
            <th>
                Author
            </th>
            <th>
                id
            </th>
            <th>
                Text
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }) %> |
                <%: Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ })%> |
                <%: Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ })%>
            </td>
            <td>
                <%: String.Format("{0:g}", item.DatePublished) %>
            </td>
            <td>
                <%: String.Format("{0:g}", item.DateModified) %>
            </td>
            <td>
                <%: item.Title %>
            </td>
            <td>
                <%: item.Description %>
            </td>
            <td>
                <%: item.Name %>
            </td>
            <td>
                <%: item.Author %>
            </td>
            <td>
                <%: item.id %>
            </td>
            <td>
                <%: item.Text %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

