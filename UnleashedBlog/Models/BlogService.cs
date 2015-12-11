using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnleashedBlog.Models.EntityFramework;
using System.Web.Mvc;
using System.Text.RegularExpressions;
using UnleashedBlog.Paging;

namespace UnleashedBlog.Models
{
    public class BlogService : BlogServiceBase
    {

       //private BlogRepositoryBase _repository;
        public BlogService(ModelStateDictionary modelState)
            : base(modelState, new EntityFrameworkBlogRepository()) { }

        public BlogService(ModelStateDictionary modelState, BlogRepositoryBase blogRepository)
            : base(modelState, blogRepository) { }

        public override BlogEntry GetBlogEntry(int id)
        {
            return _blogRepository.GetBlogEntry(id);
        }
        public override BlogEntry GetBlogEntry(int year, int month, int day, string name)
        {
            return _blogRepository.GetBlogEntry(year, month, day, name);
        }

        public override PagedList<BlogEntry> ListBlogEntries(int? page)
        {
            return _blogRepository.ListBlogEntries(page, null, null, null);
        }


        public override PagedList<BlogEntry> ListBlogEntries(int? page, int? year, int? month, int? day)
        {
            return _blogRepository.ListBlogEntries(page, year, month, day);
        }
       
        public override bool CreateBlogEntry(BlogEntry blogEntryToCreate)
        {
               // validation
            if (String.IsNullOrEmpty(blogEntryToCreate.Title))
            {
                _modelState.AddModelError("Title", "Title is required.");
            }
            /*if (blogEntryToCreate.Title.Length > 500)
            {
                _modelState.AddModelError("Title", "Title is too long.");
            }*/
            if (String.IsNullOrEmpty(blogEntryToCreate.Text))
            {
                _modelState.AddModelError("Text", "Text is required.");
            }
            if (_modelState.IsValid == false)
            {
                return false;
            }

                // Business Rules
            if (String.IsNullOrEmpty(blogEntryToCreate.Name))
            {
                blogEntryToCreate.Name = blogEntryToCreate.Title;
            }
                
                blogEntryToCreate.Name = blogEntryToCreate.Name.Replace(" ", "-");
                blogEntryToCreate.Name = Regex.Replace(blogEntryToCreate.Name,
                "[\"$&+,/:;=?@]", string.Empty);

                // Data access
                _blogRepository.CreateBlogEntry(blogEntryToCreate);
                return true;
        }
        public override bool CreateComment(Comment commentToCreate)
        {
            // Validation
            if (String.IsNullOrEmpty(commentToCreate.Title))
                _modelState.AddModelError("Title", "Title is required.");
            if (String.IsNullOrEmpty(commentToCreate.Name)){
                _modelState.AddModelError("Name", "Name is required.");
            }
            if (String.IsNullOrEmpty(commentToCreate.Text))
                _modelState.AddModelError("Text", "Comment is required.");
            if (_modelState.IsValid == false)
                return false;

            // Business rules
            if (commentToCreate.DatePublished == DateTime.MinValue)
                commentToCreate.DatePublished = DateTime.Now;

            // Data access
            _blogRepository.CreateComment(commentToCreate);
            return true;
        }


        // Archive Info methods
        public override IList<ArchiveInfo> ListBlogEntriesByMonth()
        {
            return (IList<ArchiveInfo>)_blogRepository.ListBlogEntriesByMonth();
        }
       
    }
}