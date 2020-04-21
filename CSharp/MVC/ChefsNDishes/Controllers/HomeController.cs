using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace ChefsNDishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet ("")]
        public IActionResult Index()
        {
            List<Chef> allChefs = dbContext.Chefs.Include( c => c.CreatedDishes).ToList();

            return View(allChefs);
        }

        [HttpGet ("new")]
        public IActionResult AddChef()
        {
            return View();
        }

        [HttpPost ("createchef")]
        public IActionResult CreateChef(Chef newChef)
        {
            if ( ModelState.IsValid )
            {
                dbContext.Chefs.Add(newChef);
                dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            return View("AddChef");
        }

        [HttpGet ("dishes")]
        public IActionResult Dishes()
        {
            List<Dish> allDishes = dbContext.Dishes.Include( d => d.Creator).ToList();

            return View(allDishes);
        }

        [HttpGet ("dishes/new")]
        public IActionResult AddDishes()
        {   
            ViewBag.AllChefs = dbContext.Chefs.ToList();

            return View();
        }

        [HttpPost ("createdish")]
        public IActionResult CreateDish(Dish newDish)
        {
            if ( ModelState.IsValid )
            {
                dbContext.Dishes.Add(newDish);
                dbContext.SaveChanges();

                return RedirectToAction("Dishes");
            }
            ViewBag.AllChefs = dbContext.Chefs.ToList();

            return View("AddDishes");
        }
    }
}
