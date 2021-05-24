using Microsoft.AspNetCore.Mvc;

namespace ConventionAndAttribute_Routing.Controllers
{
    public class HomeController : Controller
    {
        //This for attribute routing
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Home/Details/{id?}")]
        public int Details(int? id)
        {
            return id??1;  //?? operator means null coalescing operator
        }

        [Route("Home/About/{id?}")]
        public IActionResult About()
        {
            return View();
        }
    }
}
