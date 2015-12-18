﻿using System.Web.Mvc;
using System.Web.Mvc.Html;
using UnleashedBlog.Models;
using System.Globalization;

namespace UnleashedBlog.Helpers
{
    public static class BlogLinkHelper
    {
        public static string BlogLink(this HtmlHelper helper, BlogEntry entry)
        {
            return helper.ActionLink(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(entry.Title), "Index", "Archive", new { year = entry.DatePublished.Year, month = entry.DatePublished.Month, day = entry.DatePublished.Day, name = entry.Name }, null).ToHtmlString();
        }
    }
}