using Microsoft.AspNetCore.Mvc;

namespace Project_SBO
{
    public class MainController : Controller
    {
        [Route("")]
        [Route("main/index/{username?}")]
        public IActionResult Index(string username = "Mr. No Name") {
            var greeting = new Greeting { Username = username };
            return View(greeting);
        }
    }
    public class Greeting
    {
        public string Username {get; set;}
    }
}