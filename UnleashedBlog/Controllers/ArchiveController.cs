//using System.Web.Mvc;
//using UnleashedBlog.Models;
//using UnleashedBlog.Models.EntityFramework;
//namespace UnleashedBlog.Controllers
//{
//    public class ArchiveController : ApplicationController
//    {
//        private BlogRepositoryBase _repository;
//        public ArchiveController()
//            : this(new EntityFrameworkBlogRepository()) { }
        
//        public ArchiveController(BlogRepositoryBase repository)
//        {
//            _repository = repository;
//        }
//        public ActionResult Index(int? page,int? year, int? month, int? day, string name)
//        {
//            return View(_repository.ListBlogEntries(page,year, month, day, name));
//        }
//    }
//}

using System.Web.Mvc;
using UnleashedBlog.Models;
using UnleashedBlog.Models.EntityFramework;


namespace UnleashedBlog.Controllers
{
    public class ArchiveController : ApplicationController
    {
        public ArchiveController()
        { }

        public ArchiveController(BlogRepositoryBase blogRepository)
            : base(blogRepository) { }


    
        /// Returns a single blog entry
       
        public ActionResult Details(int year, int month, int day, string name)
        {
            return View(_blogService.GetBlogEntry(year, month, day, name));
        }

     
        /// Returns a list of blog entries that match a specified year, month, or day
        public ActionResult Index(int? page, int? year, int? month, int? day)
        {
            return View(_blogService.ListBlogEntries(page, year, month, day));
        }

    }
}