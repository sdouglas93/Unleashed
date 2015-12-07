using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UnleashedBlog.Models
{
    public class ContactInfo
    {
        // getters and setters 
        [Required(ErrorMessage = "First Name is required")]
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string comment { get; set; }

    }
}