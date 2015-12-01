using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using UnleashedBlog.Paging;

namespace UnleashedBlog.Helpers
{
    public static class BlogPagerHelper
    {
        public static string BlogPager(this HtmlHelper helper, IPagedList pager)
        {
            // Don’t display anything if not multiple pages
            if (pager.TotalPageCount == 1)
            {
                return string.Empty;
            }
            //Build route data
            var routeData = new RouteValueDictionary(helper.ViewContext.RouteData.Values);
            // Build string
            var sb = new StringBuilder();

            // render newer entries
            if (pager.PageIndex > 0) {
                routeData["page"] = pager.PageIndex - 1;
                sb.Append(helper.ActionLink("Newer Entries", "Index", routeData));
            
            }

            // Render divider
            if (pager.PageIndex > 0 && pager.PageIndex < pager.TotalPageCount - 1)
            {
                sb.Append("|");
            }

            //Render Older Entries
            if (pager.PageIndex < pager.TotalPageCount-1) {
                routeData["page"] = pager.PageIndex + 1;
                sb.Append(helper.ActionLink("Older Entries", "Index", routeData));
            
            }


            return sb.ToString();
        }
    }
}