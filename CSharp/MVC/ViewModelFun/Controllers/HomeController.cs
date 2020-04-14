using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet ("")]
        public IActionResult Index()
        {
            string message = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Officia maxime eligendi consectetur itaque tempore laboriosam provident voluptatem officiis perspiciatis doloribus eos, possimus explicabo, velit, nostrum vero odit temporibus reprehenderit vitae!";

            ViewBag.Message = message;

            return View();
        }

        [HttpGet ("numbers")]
        public IActionResult Numbers()
        {
            int[] nums = new int[6] { 1, 2, 3, 10, 43, 5 };

            return View(nums);
        }

        [HttpGet ("users")]
        public IActionResult Names()
        {
            Person name1 = new Person()
            {
                FirstName = "Moose",
                LastName = "Phillips"
            };

            Person name2 = new Person()
            {
                FirstName = "Sarah",
                LastName = ""
            };

            Person name3 = new Person()
            {
                FirstName = "Jerry",
                LastName = ""
            };

            Person name4 = new Person()
            {
                FirstName = "Rene",
                LastName = "Ricky"
            };

            Person name5 = new Person()
            {
                FirstName = "Barbarah",
                LastName = ""
            };

            List<Person> names = new List<Person>{
                name1, name2, name3, name4, name5
            };

            return View(names);
        }

        [HttpGet ("user")]
        public IActionResult Name()
        {
            Person user = new Person()
            {
                FirstName = "Moose",
                LastName = "Phillips"
            };

            return View(user);
        }
    }
}
