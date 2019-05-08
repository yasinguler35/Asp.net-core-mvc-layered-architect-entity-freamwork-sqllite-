using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using BlogApp.Data.Concrete.EfCore;
using BlogApp.Data.Abstract;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            //interface çağrınca class çalıştırsın diye
            services.AddTransient<IBlogRepository,EfBlogRepository>();
            services.AddTransient<ICategoryRepository,EfCategoryRepository>();
            // services.AddDbContext<BlogContext>(options =>options.UseSqlite("Data Source=BlogAppDb.db",b => b.MigrationsAssembly("BlogApp.WebUI")));
            // services.AddDbContext<BlogContext>(options=>options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"),b=> b.SuppressForeignKeyEnforcement()));
            services.AddDbContext<BlogContext>(options=>options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"),b => b.MigrationsAssembly("BlogApp.WebUI")));
                // "DefaultConnection":"Server=.;Database=BlogAppDb;Trusted_Connection=True"
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            // SeedData.Seed(app);
        }
    }
}

// https://sqlserver-help.com/2014/05/22/solution-the-file-mdf-is-compressed-but-does-not-reside-in-a-read-only-database-or-filegroup-the-file-must-be-decompressed/
