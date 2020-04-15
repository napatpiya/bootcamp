using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet ("")]
        public IActionResult Index()
        {
                return View();
        }

        [HttpPost ("register")]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("success");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet ("success")]
        public IActionResult Success()
        {
            return View();
        }

    }
}
