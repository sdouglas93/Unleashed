using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnleashedBlog.Models;
using UnleashedBlog.Models.EntityFramework;

namespace UnleashedBlog.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
           return View();
        }


        [HttpPost]
        public ActionResult Login(LoginAccount loginModel)
        {
            if (ModelState.IsValid)
            {
                // Create an instance of the object model 
                using (BlogDBEntities1 _entities = new BlogDBEntities1())
                {
                    /*var userDetails = (from e in _entities.RegisterDataEntities
                                       where e.UserName == loginModel.UserName &&
                                       e.Password == loginModel.Password
                                       select e);*/
                    var userDetails = _entities.RegisterDataEntities.Where(a => a.UserName.Equals(loginModel.UserName) && a.Password.Equals(loginModel.Password)).FirstOrDefault();

                    if (userDetails != null)
                    {
                        return View("Success");
                    }
                    else
                    {
                        Console.Write("Invalid User");
                    }
                }
            }

            Console.Write("Invalid User");
            return View();
        }
        public ActionResult Success()
        {
            return View("Success");
        }
    }
}
