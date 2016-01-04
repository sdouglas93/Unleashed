﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UnleashedBlog.Models
{
    public class RegisterAccount
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please provide username", AllowEmptyStrings = false)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please provide Password", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Password must be 8 char long.")]
        public string Password { get; set; }


        //[System.Web.Mvc.Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        // [Compare("Password")]
         //[DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
         //public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please provide full name", AllowEmptyStrings = false)]
        public string Name { get; set; }

        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$",
        ErrorMessage = "Please provide valid email id")]
        public string Email { get; set; }
    }

}