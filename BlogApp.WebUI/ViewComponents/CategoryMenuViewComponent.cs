using BlogApp.Data.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.WebUI.ViewComponents
{
    public class CategoryMenuViewComponent:ViewComponent
    {
        private ICategoryRepository repositroy;

        public CategoryMenuViewComponent(ICategoryRepository repo)
        {
            repositroy=repo;
        }

        public IViewComponentResult Invoke()
        {
           return View(repositroy.GetAll());
        }
    }
}