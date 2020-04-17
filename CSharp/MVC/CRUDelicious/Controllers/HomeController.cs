using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;
using Microsoft.AspNetCore.Http;

namespace CRUDelicious.Controllers
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
            List<Dish> allDishes = dbContext.Dishes.OrderByDescending( d => d.CreatedAt ).ToList();

            return View(allDishes);
        }

        [HttpGet ("new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost ("create")]
        public IActionResult Create(Dish newDish)
        {
            if ( ModelState.IsValid )
            {
                dbContext.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("New");
            }
        }

        [HttpGet ("{dishId}")]
        public IActionResult Show(int dishId)
        {
            Dish RetrievedDish = dbContext.Dishes.FirstOrDefault( d => d.DishId == dishId);

            return View(RetrievedDish);
        }

        [HttpGet ("edit/{dishId}")]
        public IActionResult Edit(int dishId)
        {
            Dish RetrievedDish = dbContext.Dishes.FirstOrDefault( d => d.DishId == dishId);

            return View(RetrievedDish);
        }

        [HttpPost ("update")]
        public IActionResult Update(int dishId, Dish updateDish)
        {
            if ( ModelState.IsValid )
            {
                
                Dish RetrievedDish = dbContext.Dishes.FirstOrDefault( d => d.DishId == dishId);

                RetrievedDish.Name = updateDish.Name;
                RetrievedDish.Chef = updateDish.Chef;
                RetrievedDish.Calories = updateDish.Calories;
                RetrievedDish.Tastiness = updateDish.Tastiness;
                RetrievedDish.Description = updateDish.Description;
                RetrievedDish.UpdatedAt = DateTime.Now;

                dbContext.Update(RetrievedDish);
                dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                Dish RetrievedDish = dbContext.Dishes.FirstOrDefault( d => d.DishId == dishId);
                return View("Edit", RetrievedDish);
            }
        }

        [HttpGet ("delete/{dishId}")]
        public IActionResult Delete(int dishId)
        {
            Dish RetrievedDish = dbContext.Dishes.FirstOrDefault( d => d.DishId == dishId);

            dbContext.Dishes.Remove(RetrievedDish);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
