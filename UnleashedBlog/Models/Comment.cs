using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnleashedBlog.Models
{
    public class Comment
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Email { get; set; }
        public string Text { get; set; }
        public DateTime DatePublished { get; set; }
        public int BlogEntryId { get; set; }
        public int id { get; set; }
    }
}