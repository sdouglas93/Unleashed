using System.Collections.Generic;
using System.Web.Mvc;
using UnleashedBlog.Models;
using UnleashedBlog.Models.EntityFramework;

namespace UnleashedBlog.Controllers
{
    public class BlogController : ApplicationController
    {
        public BlogController() { }

        public BlogController(BlogRepositoryBase blogRepository)
            : base(blogRepository) { }
        //private BlogServiceBase _blogService;

        //public BlogController()
        //{
        //    _blogService = new BlogService(this.ModelState);
        //}

        //public BlogController(BlogRepositoryBase blogRepository)
        //{
        //    _blogService = new BlogService(this.ModelState, blogRepository);
        //}

        public ActionResult Index(int? page)
        {
            return View(_blogService.ListBlogEntries(page));
        }
        public ActionResult Create()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create([Bind(Exclude = "id")]BlogEntry blogEntryToCreate)
        {
            if (_blogService.CreateBlogEntry(blogEntryToCreate) == false)
                return View();

            return RedirectToAction("Index");
        }
    }
}