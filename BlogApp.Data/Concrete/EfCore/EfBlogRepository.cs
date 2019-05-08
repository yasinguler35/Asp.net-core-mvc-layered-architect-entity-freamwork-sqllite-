using System;
using System.Linq;
using BlogApp.Data.Abstract;
using BlogApp.Entity;

namespace BlogApp.Data.Concrete.EfCore
{
    public class EfBlogRepository : IBlogRepository
    {
        private BlogContext context;
        public EfBlogRepository(BlogContext _context)
        {
            context=_context;
        }

        public void AddBlog(Blog entity)
        {
            context.Blogs.Add(entity);
            context.SaveChanges();
        }

        public void DeleteBlog(int blogId)
        {
            var blog=context.Blogs.FirstOrDefault(i=>i.BlogId==blogId);
            if (blog!=null)
            {
               context.Blogs.Remove(blog); 
               context.SaveChanges();
            }
            
        }

        public IQueryable<Blog> GetAll()
        {
            return context.Blogs;
        }

        public Blog GetById(int blogId)
        {
            var blog=context.Blogs.FirstOrDefault(i=>i.BlogId==blogId);
            return blog;
        }

        public void SaveBlog(Blog entity)
        {
            if (entity.BlogId==0)
            {
                entity.Date=DateTime.Now;
                context.Blogs.Add(entity);
            }
            else
            {
            var blog=GetById(entity.BlogId);
            if (blog!=null)
            {
                blog.Title=entity.Title;
                blog.Description=entity.Description;
                blog.CategoryId=entity.CategoryId;
                blog.Image=entity.Image;
            
            }
            }
            context.SaveChanges();
        }

        public void UpdateBlog(Blog entity)
        {
            // context.Entry(entity).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
            var blog=GetById(entity.BlogId);
            if (blog!=null)
            {
                blog.Title=entity.Title;
                blog.Description=entity.Description;
                blog.CategoryId=entity.CategoryId;
                blog.Image=entity.Image;
                context.SaveChanges();
            }
        
        }
    }
}