    using Microsoft.AspNetCore.Mvc;

    namespace FirstASPProject.Controllers     //be sure to use your own project's namespace!
    {
        public class HelloController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet]       //type of request
            [Route("")]     //associated route string (exclude the leading /)
            public ViewResult Index()
            {
                return View();
            }

            // Other code
            [HttpGet]
            [Route("{name}")]
            public string Hello(string name)
            {
                return $"Hello {name}!";
            }
            [HttpGet]
            [Route("pizza/{topping}")]
            public string PizzaParty(string topping)
            {
                return $"Who's ready for a {topping} Pizza!";
            }
            [HttpGet]
            [Route("user/{name}/{location}/{age}")]
            public string UserInfo(string name, string location, int age)
            {
                return $"{name}, aged {age}, is from {location}";
            }

        }
    }
