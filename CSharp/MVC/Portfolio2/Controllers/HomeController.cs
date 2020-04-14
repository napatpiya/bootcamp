    using Microsoft.AspNetCore.Mvc;
    namespace Portfolio2.Controllers     //be sure to use your own project's namespace!
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

            [HttpGet]
            [Route("projects")]
            public IActionResult Projects()
            {
                return View();
            }

            [HttpGet]
            [Route("contact")]
            public IActionResult Contact()
            {
                return View();
            }
        }
    }
