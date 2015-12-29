using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using UnleashedBlog.Models;
using UnleashedBlog.Models.EntityFramework;

namespace UnleashedBlog.Controllers
{
    public class RegisterController : Controller
    {
        //
        // GET: /Login/

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
       // [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterDataEntity mode) 
        {
           
            if (ModelState.IsValid) 
            {

                using (BlogDBEntities1 dc = new BlogDBEntities1())
                {
                    dc.AddToRegisterDataEntities(mode);
                    dc.SaveChanges();
                    ModelState.Clear();
                    mode = null;
                    //ViewBag.Message="Sucessfully Registration Done";
                }

                
            
            }
            return View(mode);
        }
    }
}
