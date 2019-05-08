using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BlogApp.Entity;
using System;

namespace BlogApp.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app){
          BlogContext context=app.ApplicationServices.GetRequiredService<BlogContext>();
          context.Database.Migrate();
           
        if (context.Categorys.Any())
          {
              context.Categorys.AddRange(
                  new Category(){
                           Name="category 1"
                          }
              );
              context.SaveChanges();
          }


          if (context.Blogs.Any())
          {
              context.Blogs.AddRange(
                  new Blog(){
                      Title="Blog Title 1",
                      Body="Blog Body 1",
                      Image="1.jpg",
                      Date=DateTime.Now.AddDays(-5),
                      isApproved=true,
                      CategoryId=1
                          }
              );
              context.SaveChanges();
          }

         


        }
    }
}