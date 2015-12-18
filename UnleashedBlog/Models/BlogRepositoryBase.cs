﻿//using System.Collections.Generic;
//using System.Linq;
//using Paging;
//using UnleashedBlog.Paging;

//namespace UnleashedBlog.Models
//{
//    public abstract class BlogRepositoryBase
//    {
//        // Blog Entry Methods
//        public abstract void CreateBlogEntry(BlogEntry blogEntryToCreate);
//        protected abstract IQueryable<BlogEntry> QueryBlogEntries();

//        //public virtual PagedList<BlogEntry> ListBlogEntries(int? page, int? year, int? month, int? day, string name)
//        //{
//        //    var query = this.QueryBlogEntries();
//        //    if (year.HasValue)
//        //        query = query.Where(e => e.DatePublished.Year == year.Value);
//        //    if (month.HasValue)
//        //        query = query.Where(e => e.DatePublished.Month == month.Value);
//        //    if (day.HasValue)
//        //        query = query.Where(e => e.DatePublished.Day == day.Value);
//        //    if (!string.IsNullOrEmpty(name))
//        //        query = query.Where(e => e.Name == name);

//        //    return query.OrderByDescending(e => e.DatePublished).ToPagedList(page, 2);

//        //}
//        public virtual PagedList<BlogEntry> ListBlogEntries(int? page, int? year, int? month, int? day)
//        {
//            var query = this.QueryBlogEntries();

//            if (year.HasValue)
//                query = query.Where(e => e.DatePublished.Year == year.Value);
//            if (month.HasValue)
//                query = query.Where(e => e.DatePublished.Month == month.Value);
//            if (day.HasValue)
//                query = query.Where(e => e.DatePublished.Day == day.Value);

//            return query.OrderByDescending(e => e.DatePublished).ToPagedList(page, 5);
//        }
//        public virtual BlogEntry GetBlogEntry(int id)
//        {
//            var blogEntry = this.QueryBlogEntries()
//                    .Where(e => e.id == id).FirstOrDefault();
//            //.Select(e => e)

//            blogEntry.Comments = ListComments(blogEntry.id);

//            return blogEntry;
//        }

//        public virtual BlogEntry GetBlogEntry(int year, int month, int day, string name)
//        {
//            var blogEntry = (this.QueryBlogEntries()
//                .Where(e => e.DatePublished.Year == year)
//                .Where(e => e.DatePublished.Month == month)
//                .Where(e => e.DatePublished.Day == day)
//                .Where(e => e.Name == name)).FirstOrDefault();

//            blogEntry.Comments = ListComments(blogEntry.id);

//            return blogEntry;
//        }
//        // Comment Methods

//        public abstract void CreateComment(Comment commentToCreate);
//        protected abstract IQueryable<Comment> QueryComments();

//        protected virtual List<Comment> ListComments(int blogEntryId)
//        {
//            return this.QueryComments()
//                .Where(c => c.BlogEntryId == blogEntryId)
//                .OrderBy(c => c.DatePublished)
//                .ToList();
//        }



//        // Archive Info Methods
//        public IList<ArchiveInfo> ListBlogEntriesByMonth()
//        {
//            var result = from e in this.QueryBlogEntries()
//                         group e by
//                           new { e.DatePublished.Year, e.DatePublished.Month }
//                             into g
//                             orderby g.Key.Year descending, g.Key.Month descending
//                             select new ArchiveInfo
//                             {
//                                 Year = g.Key.Year,
//                                 Month = g.Key.Month,
//                                 Count = g.Count()
//                             };

//            return result.Take(10).ToList();
//        }

//    }
//}

using System.Collections.Generic;
using System.Linq;
using Paging;
using UnleashedBlog.Paging;
using System;

namespace UnleashedBlog.Models
{
    public abstract class BlogRepositoryBase
    {
        // Blog Entry Methods
        public abstract void CreateBlogEntry(BlogEntry blogEntryToCreate);
        protected abstract IQueryable<BlogEntry> QueryBlogEntries();


        public virtual BlogEntry GetBlogEntry(int id)
        {
            id = 1;
            var blogEntry = (this.QueryBlogEntries()
                    .Where(e => e.id == id)  //.FirstOrDefault());
            .Select(e => e).FirstOrDefault());

            blogEntry.Comments = ListComments(blogEntry.id);



            try
            {
                return blogEntry;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return blogEntry;
        }

        public virtual BlogEntry GetBlogEntry(int year, int month, int day, string name)
        {
            var blogEntry = (this.QueryBlogEntries()
                .Where(e => e.DatePublished.Year == year)
                .Where(e => e.DatePublished.Month == month)
                .Where(e => e.DatePublished.Day == day)
                .Where(e => e.Name == name)).FirstOrDefault();

           

            blogEntry.Comments = ListComments(blogEntry.id);
            Console.WriteLine(blogEntry);

            return blogEntry;
        }


        public virtual PagedList<BlogEntry> ListBlogEntries(int? page, int? year, int? month, int? day)
        {
            var query = this.QueryBlogEntries();

            if (year.HasValue)
                query = query.Where(e => e.DatePublished.Year == year.Value);
            if (month.HasValue)
                query = query.Where(e => e.DatePublished.Month == month.Value);
            if (day.HasValue)
                query = query.Where(e => e.DatePublished.Day == day.Value);

            return query.OrderByDescending(e => e.DatePublished).ToPagedList(page, 5);
        }

        // Comment Methods

        public abstract void CreateComment(Comment commentToCreate);
        protected abstract IQueryable<Comment> QueryComments();

        protected virtual List<Comment> ListComments(int blogEntryId)
        {
            return this.QueryComments()
                .Where(c => c.BlogEntryId == blogEntryId)
                .OrderBy(c => c.DatePublished)
                .ToList();
        }



        // Archive Info Methods
        public IList<ArchiveInfo> ListBlogEntriesByMonth()
        {
            var result = from e in this.QueryBlogEntries()
                         group e by
                           new { e.DatePublished.Year, e.DatePublished.Month }
                             into g
                             orderby g.Key.Year descending, g.Key.Month descending
                             select new ArchiveInfo
                             {
                                 Year = g.Key.Year,
                                 Month = g.Key.Month,
                                 Count = g.Count()
                             };

            return result.Take(10).ToList();
        }


    }
}