using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ActivityCenter.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ActivityCenter.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
     
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet ("")]
        public IActionResult Index()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Signin");
        }

        [HttpGet ("signin")]
        public IActionResult Signin()
        {
            HttpContext.Session.Clear();

            return View();
        }

        [HttpPost ("verify/login")]
        public IActionResult VerifyLogin(LoginUser userSubmission)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault( u => u.Email == userSubmission.LEmail );
                if(userInDb == null)
                {
                    ModelState.AddModelError("LEmail", "Invalid Email/Password");
                    return View("Signin");
                }
                
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.LPassword);
                if(result == 0)
                {
                    ModelState.AddModelError("LEmail", "Invalid Email/Password");
                    return View("Signin");
                }

                HttpContext.Session.SetInt32("check", (int)userInDb.UserId);

                return RedirectToAction("Home");
            }

            return View("Signin");
            
        }

        [HttpPost ("verify/register")]
        public IActionResult VerifyRegister(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    
                    return View("Signin");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password); 

                    dbContext.Users.Add(newUser);
                    dbContext.SaveChanges();

                    var userInDb = dbContext.Users.FirstOrDefault( u => u.Email == newUser.Email );

                    HttpContext.Session.SetInt32("check", (int)userInDb.UserId);

                    return RedirectToAction("Home");
                }
            }

            return View("Signin");
            
        }

        [HttpGet ("home")]
        public IActionResult Home()
        {
            ViewBag.Check = HttpContext.Session.GetInt32("check");
            if ( ViewBag.Check != null )
            {
                int userId = (int)HttpContext.Session.GetInt32("check");

                ViewBag.UserLogin = dbContext.Users
                    .Include( u => u.Subscriptions )
                    .ThenInclude( s => s.Events )
                    .FirstOrDefault( u => u.UserId == userId);

                ViewBag.AllUsers = dbContext.Users.ToList();

                DateTime checkDate = DateTime.Now;

                ViewBag.AllActivities = dbContext.Events
                    .Include( e => e.UsersJoin )
                    .ThenInclude( s => s.User )
                    .Where( e => e.StartTime > checkDate )
                    .OrderBy( e => e.CreatedAt )
                    .ToList();

                return View();
            }

            return RedirectToAction("Signin");
            
        }

        [HttpGet ("new")]
        public IActionResult New()
        {
            ViewBag.Check = HttpContext.Session.GetInt32("check");
            if ( ViewBag.Check != null )
            {
                ViewBag.UserId = HttpContext.Session.GetInt32("check");

                return View();
            }

            return RedirectToAction("Signin");
        }

        [HttpPost ("create/activity/{userId}")]
        public IActionResult CreateActivity(Event newEvent, int userId)
        {
            if ( ModelState.IsValid )
            {
                newEvent.UserId = userId;

                dbContext.Events.Add(newEvent);
                dbContext.SaveChanges();

                ViewBag.Activity = dbContext.Events.FirstOrDefault( e => e.Title == newEvent.Title);

                return RedirectToAction("ShowActivity", new {@activityId = ViewBag.Activity.ActivityId});
            }

            ViewBag.UserId = HttpContext.Session.GetInt32("check");

            return View("New");

        }

        [HttpGet ("activity/{activityId}")]
        public IActionResult ShowActivity(int activityId)
        {
            ViewBag.Check = HttpContext.Session.GetInt32("check");
            if ( ViewBag.Check != null )
            {
                ViewBag.Activity = dbContext.Events
                    .Include( e => e.UsersJoin )
                    .ThenInclude( s => s.User )
                    .FirstOrDefault( e => e.ActivityId == activityId );

                int userId = ViewBag.Activity.UserId;
                ViewBag.Creator = dbContext.Users.FirstOrDefault( u => u.UserId == userId);

                return View();
            }

            return RedirectToAction("Signin");
        }

        [HttpGet ("/delete/activity/{activityId}/{userId}")]
        public IActionResult DeleteActivity(int activityId, int userId)
        {
            Event cancel = dbContext.Events.FirstOrDefault( e => e.ActivityId == activityId);

            dbContext.Events.Remove(cancel);
            dbContext.SaveChanges();

            HttpContext.Session.SetInt32("check", userId);

            return RedirectToAction("Home");
        }

        [HttpGet ("/join/activity/{activityId}/{userId}")]
        public IActionResult JoinActivity(int activityId, int userId)
        {
            Subscription join = new Subscription();

            join.UserId = userId;
            join.ActivityId = activityId;

            dbContext.Subscriptions.Add(join);
            dbContext.SaveChanges();

            HttpContext.Session.SetInt32("check", userId);

            return RedirectToAction("Home");
        }

        [HttpGet ("/leave/activity/{activityId}/{userId}")]
        public IActionResult LeaveActivity(int activityId, int userId)
        {
            Subscription leave = dbContext.Subscriptions.FirstOrDefault( s => s.UserId == userId && s.ActivityId == activityId);

            dbContext.Subscriptions.Remove(leave);
            dbContext.SaveChanges();

            HttpContext.Session.SetInt32("check", userId);

            return RedirectToAction("Home");
        }

    }
}
