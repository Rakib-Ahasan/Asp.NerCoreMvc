using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TempData_Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["var1"] = "View Data";
            ViewBag.var2 = "View Bag";
            TempData["var3"] = "Temp Data";
            return View();
        }
        public IActionResult About()
        {
            TempData.Keep("var3");
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
