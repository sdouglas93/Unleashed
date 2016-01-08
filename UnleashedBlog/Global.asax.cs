﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UnleashedBlog
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               "Register",
               "register/{Register}",
                new { controller = "Register", action = "Register" }
           );

            /*routes.MapRoute(
               "Login",
               "Login/{Login}",
                new { controller = "Login", action = "Login" }
           );

            routes.MapRoute(
              "Success",
              "Success/{Login}",
               new { controller = "Login", action = "Success" }
          );*/

            routes.MapRoute(
               "Details",
               "archive/{year}/{month}/{day}/{name}",
                new { controller = "Archive", action = "Details" }
           );

            routes.MapRoute(
            "archivefull",
            "archive/{year}/{month}/{day}/{name}",
             new { controller = "archive", action = "index" }
            );
            
            routes.MapRoute(
            "ArchiveYearMonthDay",
            "archive/{year}/{month}/{day}",
             new { controller = "Archive", action = "Index" }
             );

            routes.MapRoute(
            "ArchiveYearMonth",
            "archive/{year}/{month}",
             new { controller = "Archive", action = "Index" }
             );

            routes.MapRoute(
            "ArchiveYear",
            "archive/{year}",
             new { controller = "Archive", action = "Index" }
             );

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Blog", action = "Index", id = "" } // Parameter defaults
            );

            routes.MapRoute(
               "Contact", // Route name
               "contact/{Contact}", // URL with parameters
               new { controller = "Contact", action = "Index"} // Parameter defaults
           );

            routes.MapRoute(
               "Contacts", // Route name
               "contact/{Contact}", // URL with parameters
               new { controller = "View", action = "Contact" } // Parameter defaults
           );

            

           // routes.MapRoute(
           //    "Details",
           //    "archive/{Details}",
           //     new { controller = "Archive", action = "Details" }
           //);
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterRoutes(RouteTable.Routes);
        }
    }
}