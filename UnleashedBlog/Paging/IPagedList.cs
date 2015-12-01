using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnleashedBlog.Paging
{
    public interface IPagedList
    {
        int PageIndex { get; set; }
        int PageSize { get; set; }
        string SortExpression { get; set; }
        int TotalItemCount { get; set; }
        int TotalPageCount { get; }
    }
}
