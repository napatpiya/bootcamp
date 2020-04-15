using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using RandomPasscode.Models;

namespace RandomPasscode.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet ("")]
        public IActionResult Index()
        {
            Console.WriteLine("### Start Index ###");
            Console.WriteLine(HttpContext.Session.GetInt32("Count"));
            Console.WriteLine(HttpContext.Session.GetString("Gen"));
            ViewBag.Count = HttpContext.Session.GetInt32("Count");
            if (ViewBag.Count == null)
            {
                HttpContext.Session.SetInt32("Count", 1);
                ViewBag.Count = HttpContext.Session.GetInt32("Count");
                HttpContext.Session.SetString("Gen", RandomString(14));
                ViewBag.Gen = HttpContext.Session.GetString("Gen");
            }
            else
            {
                ViewBag.Count = HttpContext.Session.GetInt32("Count");
                ViewBag.Gen = HttpContext.Session.GetString("Gen");
            }

            Console.WriteLine("### End Index ###");
            Console.WriteLine(HttpContext.Session.GetInt32("Count"));
            Console.WriteLine(HttpContext.Session.GetString("Gen"));
            
            return View();
        }

        [HttpGet ("generate")]
        public IActionResult Generate()
        {
            Console.WriteLine("### Start Gen ###");
            Console.WriteLine(HttpContext.Session.GetInt32("Count"));
            Console.WriteLine(HttpContext.Session.GetString("Gen"));
            int? Count = HttpContext.Session.GetInt32("Count") + 1;
            HttpContext.Session.SetString("Gen", RandomString(14));
            HttpContext.Session.SetInt32("Count", (int) Count);
            Console.WriteLine("### End Gen ###");
            Console.WriteLine(HttpContext.Session.GetInt32("Count"));
            Console.WriteLine(HttpContext.Session.GetString("Gen"));
            return RedirectToAction("Index");
        }

        [HttpGet ("reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index");
        }


        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
