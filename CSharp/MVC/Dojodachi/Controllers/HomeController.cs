using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Dojodachi.Models;

namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        Random rand = new Random();

        [HttpGet ("")]
        public IActionResult Index()
        {
            ViewBag.Check = HttpContext.Session.GetString("Check");
            if ( ViewBag.Check == null || ViewBag.Check == "" )
            {
                HttpContext.Session.SetInt32("Fullness", 20);
                HttpContext.Session.SetInt32("Happiness", 20);
                HttpContext.Session.SetInt32("Meals", 3);
                HttpContext.Session.SetInt32("Energy", 50);
                HttpContext.Session.SetString("Images", "/imgs/cover.jpg");
                HttpContext.Session.SetString("Comment", "Let's get started!");
                HttpContext.Session.SetString("Check", "f"); 

                ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
                ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
                ViewBag.Meals = HttpContext.Session.GetInt32("Meals");
                ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
                ViewBag.Images = HttpContext.Session.GetString("Images");
                ViewBag.Comment = HttpContext.Session.GetString("Comment");
                ViewBag.Check = HttpContext.Session.GetString("Check");
            }
            else
            {
                ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
                ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
                ViewBag.Meals = HttpContext.Session.GetInt32("Meals");
                ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
                ViewBag.Images = HttpContext.Session.GetString("Images");
                ViewBag.Comment = HttpContext.Session.GetString("Comment");
                ViewBag.Check = HttpContext.Session.GetString("Check");
            }

            if ( IsWin() )
            {
                ViewBag.Images = HttpContext.Session.GetString("Images");
                ViewBag.Comment = HttpContext.Session.GetString("Comment");
                ViewBag.Check = HttpContext.Session.GetString("Check");
            }
            else
            {
                if ( IsDead() )
                {
                    ViewBag.Images = HttpContext.Session.GetString("Images");
                    ViewBag.Comment = HttpContext.Session.GetString("Comment");
                    ViewBag.Check = HttpContext.Session.GetString("Check");
                }
            }

            return View();
        }

        [HttpGet ("feed")]
        public IActionResult Feed()
        {
            if ( HttpContext.Session.GetInt32("Meals") > 0 )
            {
                int Meals = (int)HttpContext.Session.GetInt32("Meals") - 1;
                HttpContext.Session.SetInt32("Meals", (int)Meals);
                if ( rand.Next(1,5) == 2)
                {
                    HttpContext.Session.SetString("Comment", "Dochi don't like it. -> Meals -1");
                    int idex = rand.Next(1, 2);
                    HttpContext.Session.SetString("Images", $"/imgs/nofeed{idex}.jpg");
                }
                else
                {
                    int NumInc = rand.Next(5, 11);
                    int FullnessInc = (int)HttpContext.Session.GetInt32("Fullness") + NumInc;
                    HttpContext.Session.SetInt32("Fullness", FullnessInc);
                    HttpContext.Session.SetString("Comment", $"Dachi -> Fullness +{NumInc}, Meal -1");
                    int idex = rand.Next(1, 5);
                    HttpContext.Session.SetString("Images", $"/imgs/feed{idex}.jpg");
                }

            }
            else
            {
                HttpContext.Session.SetString("Comment", "Daji cannot feeding! Daji meal is empty.");
            }

            return RedirectToAction("Index");
        }

        [HttpGet ("play")]
        public IActionResult Play()
        {
            if ( HttpContext.Session.GetInt32("Energy") > 5 )
            {
                int Energy = (int)HttpContext.Session.GetInt32("Energy") - 5;
                HttpContext.Session.SetInt32("Energy", (int)Energy);
                if ( rand.Next(1,5) == 2)
                {
                    HttpContext.Session.SetString("Comment", "Dachi don't like it. -> Energy -5");
                    int idex = rand.Next(1, 2);
                    HttpContext.Session.SetString("Images", $"/imgs/noplay{idex}.jpg");
                }
                else
                {
                    int NumInc = rand.Next(5, 11);
                    int HappinessInc = (int)HttpContext.Session.GetInt32("Happiness") + NumInc;
                    HttpContext.Session.SetInt32("Happiness", HappinessInc);
                    HttpContext.Session.SetString("Comment", $"Dachi -> Happiness +{NumInc}, Energy -5");
                    int idex = rand.Next(1, 5);
                    HttpContext.Session.SetString("Images", $"/imgs/play{idex}.jpg");
                }  

            }
            else
            {
                HttpContext.Session.SetString("Comment", "Daji cannot playing! Daji energy is not enough.");
            }

            return RedirectToAction("Index");
        }

        [HttpGet ("work")]
        public IActionResult Work()
        {
            if ( HttpContext.Session.GetInt32("Energy") > 5 )
            {
                int Energy = (int)HttpContext.Session.GetInt32("Energy") - 5;
                HttpContext.Session.SetInt32("Energy", (int)Energy);
                int NumInc = rand.Next(1, 4);
                int MealsInc = (int)HttpContext.Session.GetInt32("Meals") + NumInc;
                HttpContext.Session.SetInt32("Meals", MealsInc);
                HttpContext.Session.SetString("Comment", $"Dachi -> Meals +{NumInc}, Energy -5");   
                int idex = rand.Next(1, 2);
                HttpContext.Session.SetString("Images", $"/imgs/work{idex}.jpg");            
            }
            else
            {
                HttpContext.Session.SetString("Comment", "Daji cannot working! Daji energy is not enough.");
            }

            return RedirectToAction("Index");
        }

        [HttpGet ("sleep")]
        public IActionResult Sleep()
        {
            int FullnessDec = (int)HttpContext.Session.GetInt32("Fullness") - 5;
            int HappinessDec = (int)HttpContext.Session.GetInt32("Happiness") - 5;
            HttpContext.Session.SetInt32("Fullness", (int)FullnessDec);
            HttpContext.Session.SetInt32("Happiness", (int)HappinessDec);

            int EnergyInc = (int)HttpContext.Session.GetInt32("Energy") + 15;
            HttpContext.Session.SetInt32("Energy", (int)EnergyInc);
            HttpContext.Session.SetString("Comment", $"Dachi -> Energy +15, Fullness -5, Happiness -5"); 
            
            int idex = rand.Next(1, 5);
            HttpContext.Session.SetString("Images", $"/imgs/sleep{idex}.jpg"); 

            return RedirectToAction("Index");
        }

        [HttpGet ("restart")]
        public IActionResult Restart()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index");
        }

        public bool IsDead()
        {
            if ( (int)HttpContext.Session.GetInt32("Fullness") < 1 || (int)HttpContext.Session.GetInt32("Happiness") < 1 )
            {
                HttpContext.Session.SetString("Comment", "Your Dojodachi has passed away..");
                HttpContext.Session.SetString("Check", "t");

                int idex = rand.Next(1, 2);
                HttpContext.Session.SetString("Images", $"/imgs/lose{idex}.jpg"); 

                return true;
            }

            return false;
        }

        public bool IsWin()
        {
            if ( (int)HttpContext.Session.GetInt32("Fullness") > 100 && (int)HttpContext.Session.GetInt32("Happiness") > 100 && (int)HttpContext.Session.GetInt32("Energy") > 100 )
            {
                HttpContext.Session.SetString("Comment", "Congratulation! You won!");
                HttpContext.Session.SetString("Check", "t");

                int idex = rand.Next(1, 2);
                HttpContext.Session.SetString("Images", $"/imgs/win{idex}.jpg"); 

                return true;
            }

            return false;
        }

    }
}
