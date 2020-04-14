    using Microsoft.AspNetCore.Mvc;
    namespace DojoSurvey.Controllers     //be sure to use your own project's namespace!
    {
        public class HomeController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet]       //type of request
            [Route("")]     //associated route string (exclude the leading /)
            public IActionResult Index()
            {
                return View();
            }

            [HttpPost]       //type of request
            [Route("result")]     //associated route string (exclude the leading /)
            public IActionResult Result(string yourname, string location, string favorite, string comment)
            {
                ViewBag.Name = yourname;
                ViewBag.Location = location;
                ViewBag.Favorite = favorite;
                ViewBag.Comment = comment;

                return View();
            }
        }
    }
