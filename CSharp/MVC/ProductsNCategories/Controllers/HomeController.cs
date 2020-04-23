using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductsNCategories.Models;
using Microsoft.EntityFrameworkCore;

namespace ProductsNCategories.Controllers
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
            List<Product> allProduct = dbContext.Products
                .Include( p => p.CategoryGroup )
                .ThenInclude( a => a.Category )
                .ToList();

            return View(allProduct);
        }

        [HttpGet ("products")]
        public IActionResult Products()
        {
            ViewBag.AllProducts = dbContext.Products.ToList();

            return View();
        }

        [HttpPost ("create/product")]
        public IActionResult CreateProduct(Product newProduct)
        {
            ViewBag.AllProducts = dbContext.Products.ToList();

            if ( ModelState.IsValid )
            {
                dbContext.Products.Add(newProduct);
                dbContext.SaveChanges();

                return RedirectToAction("Products");
            }

            return View("Products");
        }

        [HttpGet ("categories")]
        public IActionResult Categories()
        {
            ViewBag.AllCategories = dbContext.Categories.ToList();

            return View();
        }

        [HttpPost ("create/category")]
        public IActionResult CreateCategory(Category newCategory)
        {
            ViewBag.AllCategories = dbContext.Categories.ToList();

            if ( ModelState.IsValid )
            {
                dbContext.Categories.Add(newCategory);
                dbContext.SaveChanges();

                return RedirectToAction("Categories");
            }

            return View("Categories");
        }

        [HttpGet ("product/{productId}")]
        public IActionResult ShowProduct(int productId)
        {
            ViewBag.Product = dbContext.Products
                .Include( p => p.CategoryGroup )
                .ThenInclude( a => a.Category )
                .FirstOrDefault( product => product.ProductId == productId );

            Product thisProduct = dbContext.Products
                .Include( p => p.CategoryGroup )
                .ThenInclude( a => a.Category )
                .FirstOrDefault( product => product.ProductId == productId );
            List<Category> All = dbContext.Categories.ToList();
            List<Category> BeenThere = thisProduct.CategoryGroup.Select( a => a.Category ).ToList();

            ViewBag.AllCategories = All.Except(BeenThere);

            return View();
        }

        [HttpPost ("add/category/{productId}")]
        public IActionResult AddCategory(int productId, Association newAssociation)
        {
            newAssociation.ProductId = productId;

            dbContext.Associations.Add(newAssociation);
            dbContext.SaveChanges();

            return RedirectToAction("ShowProduct", new {@productId = productId});
        }

        [HttpGet ("category/{categoryId}")]
        public IActionResult ShowCategory(int categoryId)
        {
            ViewBag.Category = dbContext.Categories
                .Include( c => c.ProductGroup )
                .ThenInclude( a => a.Product )
                .FirstOrDefault( category => category.CategoryId == categoryId );

            Category thisCategory = dbContext.Categories
                .Include( c => c.ProductGroup )
                .ThenInclude( a => a.Product )
                .FirstOrDefault( category => category.CategoryId == categoryId );
            List<Product> All = dbContext.Products.ToList();
            List<Product> BeenThere = thisCategory.ProductGroup.Select( a => a.Product ).ToList();
            
            ViewBag.AllProducts = All.Except(BeenThere);

            return View();
        }

        [HttpPost ("add/product/{categoryId}")]
        public IActionResult AddProduct(int categoryId, Association newAssociation)
        {
            newAssociation.CategoryId = categoryId;

            dbContext.Associations.Add(newAssociation);
            dbContext.SaveChanges();

            return RedirectToAction("ShowCategory", new {@categoryId = categoryId});
        }
    }
}
