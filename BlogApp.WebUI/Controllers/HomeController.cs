using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogApp.WebUI.Models;
using BlogApp.Data.Abstract;

namespace BlogApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IBlogRepository blogRepositroy;

        public HomeController(IBlogRepository repository)
        {
           blogRepositroy=repository;
        }

        public IActionResult Index()
        {
            return View(blogRepositroy.GetAll());
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }


    }
}
