using System.Web.Mvc;
using UnleashedBlog.Models;
using UnleashedBlog.Models.EntityFramework;
namespace UnleashedBlog.Controllers
{
    public class ArchiveController : Controller
    {
        private BlogRepositoryBase _repository;
        public ArchiveController()
            : this(new EntityFrameworkBlogRepository()) { }
        
        public ArchiveController(BlogRepositoryBase repository)
        {
            _repository = repository;
        }
        public ActionResult Index(int? page,int? year, int? month, int? day, string name)
        {
            return View(_repository.ListBlogEntries(page,year, month, day, name));
        }
    }
}