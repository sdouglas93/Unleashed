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

        private BlogDBEntities1 _entities = new BlogDBEntities1();
       // protected abstract IQueryable<RegisterAccount> QueryBlogEntries();
        

        // GET: /Login/

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        private RegisterDataEntity ConvertRegisterAccountToRegisterDataEntity(RegisterAccount entry)
        {
            var entity = new RegisterDataEntity();

            entity.UserId = entry.UserId;
            entity.UserName = entry.UserName;
            entity.Password = entry.Password;
            entity.Name = entry.Name;
            entity.Email = entry.Email;

            return entity;
        }

        private IQueryable<RegisterAccount> QueryBlogEntries()
        {
            return from e in _entities.RegisterDataEntities
                   select new RegisterAccount
                   {
                       UserId = e.UserId,
                       UserName = e.UserName,
                       Password = e.Password,
                       Name = e.Name,
                       Email = e.Email,
                   };
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterAccount mode)
        {
            var entity = ConvertRegisterAccountToRegisterDataEntity(mode);
            if (ModelState.IsValid)
            {
                _entities.AddToRegisterDataEntities(entity);
                _entities.SaveChanges();
                ModelState.Clear();
                mode = null;

            }
            return View(mode);
        }
       

    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public ActionResult Register(RegisterDataEntity mode) 
    //    {
           
    //        if (ModelState.IsValid) 
    //        {

    //            using (BlogDBEntities1 dc = new BlogDBEntities1())
    //            {
    //                dc.AddToRegisterDataEntities(mode);
    //                dc.SaveChanges();
    //                ModelState.Clear();
    //                //mode = null;
    //                //ViewBag.Message="Sucessfully Registration Done";
    //            }
    //        }
    //        return View(mode);
    //    }

        

        
    }
}
