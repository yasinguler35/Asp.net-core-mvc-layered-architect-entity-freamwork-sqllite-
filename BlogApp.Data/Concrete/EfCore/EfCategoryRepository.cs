using System.Linq;
using BlogApp.Data.Abstract;
using BlogApp.Entity;

namespace BlogApp.Data.Concrete.EfCore
{
    public class EfCategoryRepository : ICategoryRepository
    {
        private BlogContext context;
        public EfCategoryRepository(BlogContext _context)
        {
            context=_context;
        }

        public void AddCategory(Category entity)
        {
            context.Categorys.Add(entity);
            context.SaveChanges();
        }

        public void DeleteCategory(int categoryId)
        {
           var category=context.Categorys.FirstOrDefault(i=>i.CategoryId==categoryId);
           if (category!=null)
           {
               context.Categorys.Remove(category);
               context.SaveChanges();
           }
        }

        public IQueryable<Category> GetAll()
        {
            return context.Categorys;
        }

        public Category GetById(int categoryId)
        {
             var category=context.Categorys.FirstOrDefault(i=>i.CategoryId==categoryId);
             return category ;
        }

        public void SaveCategory(Category entity)
        {
            if (entity.CategoryId==0)
            {
                context.Categorys.Add(entity);
            }
            else
            {
            var category=GetById(entity.CategoryId);
            if (category!=null)
            {
              category.Name=entity.Name;
            
            }
            }
            context.SaveChanges();
        }

        public void UpdateCategory(Category entity)
        {
          context.Entry(entity).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
          context.SaveChanges();
        }
    }
}