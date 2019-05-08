using System;
using BlogApp.Data.Abstract;
using BlogApp.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogApp.WebUI.Controllers
{
    public class BlogController:Controller
    {
        private IBlogRepository _blogRepositroy;
         private ICategoryRepository _categoryRepositroy;
        public BlogController(IBlogRepository _blogRepo,ICategoryRepository _categoryRepo)
        {
            _blogRepositroy=_blogRepo;
            _categoryRepositroy=_categoryRepo;
        }
        public IActionResult Index()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
        public IActionResult List()
        {
          //TODO: Implement Realistic Implementation
          return View(_blogRepositroy.GetAll());
        }
        // public IActionResult Create()
        // {
        //   ViewBag.Categories=new SelectList(_categoryRepositroy.GetAll(),"CategoryId","Name");
        //   //TODO: Implement Realistic Implementation
        //   return View();
        // }
        // [HttpPost]
        // public IActionResult Create(Blog entity)
        // {
        //   //TODO: Implement Realistic Implementation
        //   entity.Date=DateTime.Now;
        //   if (ModelState.IsValid)
        //   {
        //      _blogRepositroy.AddBlog(entity);
        //      return RedirectToAction("list");
        //   }
        // return View(entity);
         
        // }

        public IActionResult AddorUpdate(int? id)
        {
          ViewBag.Categories=new SelectList(_categoryRepositroy.GetAll(),"CategoryId","Name");
          if (id==null)
          {
              //yeni bir kayıt
              return View(new Blog());
          }
          else
          {
            return View(_blogRepositroy.GetById((int)id));
          }
          //TODO: Implement Realistic Implementation
         
        }

        [HttpPost]
        public IActionResult AddorUpdate(Blog entity)
        {
          //TODO: Implement Realistic Implementation
          if (ModelState.IsValid)
          {
              _blogRepositroy.SaveBlog(entity);
              TempData["message"]=$"{entity.Title} kayıt edildi";
              return RedirectToAction("List");
          }
          ViewBag.Categories=new SelectList(_categoryRepositroy.GetAll(),"CategoryId","Name");
          return View(entity);
        }
        public IActionResult Delete(int id)
        {
          _blogRepositroy.DeleteBlog(id);
          //TODO: Implement Realistic Implementation
          return RedirectToAction("List");
        }
    }
}