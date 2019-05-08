using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Concrete.EfCore
{
    public class BlogContext:DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options):base(options)
        {
            
        }
        public DbSet<Blog> Blogs{ get; set; }
        public DbSet<Category> Categorys { get; set; }
         public DbSet<Person> Person { get; set; }
         public DbSet<Register> Register { get; set; }
    }
}