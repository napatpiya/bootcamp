using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankAccount.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BankAccount.Controllers
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
            HttpContext.Session.SetInt32("check", 0);
            return View();
        }

        [HttpPost ("verify/register")]
        public IActionResult VerifyRegister(User newUser)
        {
            // Check initial ModelState
            if(ModelState.IsValid)
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

                    dbContext.Users.Add(newUser);
                    dbContext.SaveChanges();

                    var userInDb = dbContext.Users.FirstOrDefault( u => u.Email == newUser.Email );
                    HttpContext.Session.SetInt32("check", (int)userInDb.UserId);

                    return RedirectToAction("Account", new {@userId = userInDb.UserId});
                }
            }

            return View("Index");
            // other code
        } 

        [HttpGet ("login")]
        public IActionResult Login()
        {
            HttpContext.Session.SetInt32("check", 0);

            return View();
        }

        [HttpPost ("verify/login")]
        public IActionResult VerifyLogin(LoginUser userSubmission)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault( u => u.Email == userSubmission.Email );
                if(userInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }
                
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.Password);
                if(result == 0)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }

                HttpContext.Session.SetInt32("check", (int)userInDb.UserId);

                return RedirectToAction("Account", new {@userId = userInDb.UserId});
            }

            return View("Login");
        }

        [HttpGet ("account/{userId}")]
        public IActionResult Account(int userId)
        {
            if ( HttpContext.Session.GetInt32("check") == userId )
            {
                ViewBag.UserLogin = dbContext.Users.Include( u => u.CreateTransaction ).FirstOrDefault( u => u.UserId == userId );

                ViewBag.AllTran = dbContext.Transactions.Where( t => t.UserId == userId ).ToList();

                return View();
            }
            
            HttpContext.Session.SetInt32("check", 0);
            
            return RedirectToAction("Login");
            
        }

        [HttpPost ("transaction/{userId}")]
        public IActionResult AddTran(int userId, Transaction newTran)
        {
            newTran.UserId = userId;

            if ( newTran.Amount < 0 )
            {
                decimal sum = dbContext.Transactions.Where( t => t.UserId == userId ).Select( t => t.Amount ).DefaultIfEmpty().Sum();
                if ( sum + newTran.Amount < 0 )
                {
                    ModelState.AddModelError("Amount", "Not have enough money!");
                    ViewBag.UserLogin = dbContext.Users.Include( u => u.CreateTransaction ).FirstOrDefault( u => u.UserId == userId );
                    ViewBag.AllTran = dbContext.Transactions.Where( t => t.UserId == userId ).ToList();
                    return View("Account");
                }
            }

            dbContext.Transactions.Add(newTran);
            dbContext.SaveChanges();

            return RedirectToAction("Account", new {@userId = userId});
        }
    }
}
