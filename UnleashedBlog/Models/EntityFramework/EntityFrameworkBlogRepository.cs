using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnleashedBlog.Models.EntityFramework
{
    public class EntityFrameworkBlogRepository: BlogRepositoryBase
    {
        private BlogDBEntities _entities = new BlogDBEntities();

        private BlogEntryEntity ConvertBlogEntryToBlogEntryEntity(BlogEntry entry) {

            var entity = new BlogEntryEntity();

            entity.id = entry.id;
            entity.Author = entry.Author;
            entity.Description = entry.Description;
            entity.Name = entry.Name;
            entity.DatePublished = entry.DatePublished;
            entity.DateModified = entry.DateModified;
            entity.Text = entry.Text;
            entity.Title = entry.Title;

            return entity;
        }

        private CommentEntity ConvertCommentToCommentEntity(Comment comment)
        {
            var entity = new CommentEntity();
            entity.id = comment.id;
            entity.BlogEntryId = comment.BlogEntryId;
            entity.DatePublished = comment.DatePublished;
            entity.Email = comment.Email;
            entity.Name = comment.Name;
            entity.Text = comment.Text;
            entity.Title = comment.Title;
            entity.Url = comment.Url;
            return entity;
        }

        protected override IQueryable<BlogEntry> QueryBlogEntries()
        {
          //  throw new NotImplementedException();
            return from e in _entities.BlogEntryEntities
                   select new BlogEntry
                   {
                       id = e.id,
                       Author = e.Author,
                       Description = e.Description,
                       Name = e.Name,
                       DateModified = e.DateModified,
                       DatePublished= e.DatePublished,
                       Text = e.Text,
                       Title = e.Title,
                       CommentCount = (from c in _entities.CommentEntities
                                       where c.BlogEntryId == e.id
                                       select c).Count()
                       
                   };

        }

        protected override IQueryable<Comment> QueryComments()
        {
            return from c in _entities.CommentEntities
                   select new Comment
                   {
                       id = c.id,
                       BlogEntryId = c.BlogEntryId,
                       DatePublished = c.DatePublished,
                       Email = c.Email,
                       Name = c.Name,
                       Text = c.Text,
                       Title = c.Title,
                       Url = c.Url
                   };
        }
        public override void CreateBlogEntry(BlogEntry blogEntryToCreate)
        {
            var entity = ConvertBlogEntryToBlogEntryEntity(blogEntryToCreate);
            _entities.AddToBlogEntryEntities(entity);
            _entities.SaveChanges();
        }

        public override void CreateComment(Comment commentToCreate)
        {
            var entity = ConvertCommentToCommentEntity(commentToCreate);

            _entities.AddToCommentEntities(entity);
            _entities.SaveChanges();
        }
    }
}