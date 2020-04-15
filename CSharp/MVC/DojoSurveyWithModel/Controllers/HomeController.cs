using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithModel.Models;

namespace DojoSurveyWithModel.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost ("submission")]
        public IActionResult Submission(Survey survey)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("result", survey);
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet ("result")]
        public IActionResult Result(Survey newSurvey)
        {
            return View(newSurvey);
        }

    }
}
