using BlogApp.Data.Abstract;
using BlogApp.Entity;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.WebUI.Controllers
{
    public class CategoryController:Controller
    {
        private ICategoryRepository repositroy;

        public CategoryController(ICategoryRepository _repo)
        {
            repositroy=_repo;
        }
        public IActionResult Index()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
        public IActionResult List()
        {
          //TODO: Implement Realistic Implementation
            return View(repositroy.GetAll());
        }
        // public IActionResult Create()
        // {
        //   //TODO: Implement Realistic Implementation
        //   return View();
        // }
        // [HttpPost]
        // public IActionResult Create(Category entity)
        // {
        //   if (ModelState.IsValid)
        //   {
        //      repositroy.AddCategory(entity);
        //      return RedirectToAction("list");
        //   }
        //   //TODO: Implement Realistic Implementation
        //   return View();
        // }
        public IActionResult AddorUpdate(int? id)
        {
          //TODO: Implement Realistic Implementation
          if (id==null)
          {
              return View(new Category());
          }
          else
          {
            return View(repositroy.GetById((int)id));
          }
        }
        [HttpPost]
        public IActionResult AddorUpdate(Category entity)
        {
          //TODO: Implement Realistic Implementation
          if (ModelState.IsValid)
          {
              repositroy.SaveCategory(entity);
              TempData["message"]=$"{entity.Name} kayıt edildi";
              return RedirectToAction("List");
          }
          return View(entity);
        }
    }
}