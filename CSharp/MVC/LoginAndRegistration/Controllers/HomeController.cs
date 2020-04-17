using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginAndRegistration.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace LoginAndRegistration.Controllers
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
            List<User> AllUsers = dbContext.Users.ToList();
            HttpContext.Session.SetString("login", "f");
            return View();
        }

        [HttpPost ("verifyregister")]
        public IActionResult Verifyregister(User newUser)
        {
            if ( ModelState.IsValid )
            {
                if(dbContext.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    
                    return View("Index");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);

                    dbContext.Add(newUser);
                    dbContext.SaveChanges();

                    HttpContext.Session.SetString("login", "t");

                    return RedirectToAction("Success");
                }
            }

            return View("Index");
        }

        [HttpGet ("login")]
        public IActionResult Login()
        {
            HttpContext.Session.SetString("login", "f");
            return View();
        }

        [HttpPost ("verifylogin")]
        public IActionResult Verifylogin(LoginUser loginUser)
        {
            if ( ModelState.IsValid )
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == loginUser.Email);
                // If no user exists with provided email
                if(userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("Password", "Invalid Email/Password");
                    return View("Login");
                }
                
                // Initialize hasher object
                var hasher = new PasswordHasher<LoginUser>();
                
                // verify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(loginUser, userInDb.Password, loginUser.Password);
                
                // result can be compared to 0 for failure
                if(result == 0)
                {
                    // handle failure (this should be similar to how "existing email" is handled)
                    ModelState.AddModelError("Password", "Invalid Email/Password");
                    return View("Login");
                }

                // var userId = dbContext.Users
                //     .Where(user => user.Email == loginUser.Email)
                //     .Select(user => user.UserId);

                HttpContext.Session.SetString("login", "t");

                return RedirectToAction("Success");
            }

            return View("Login");
        }


        [HttpGet ("success")] 
        public IActionResult Success()
        {
            if ( HttpContext.Session.GetString("login") == "t" )
            {
                return View("Success");
            }

            return Redirect("login");   
            
        }

    }
}
