using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewBag_Demo.Models;

namespace ViewBag_Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.var1 = "Data comes from ViewBag.";
            ViewBag.var2 = DateTime.Now.ToLongDateString();
            string[] arr = {"ali", "kamal", "jamal"};
            ViewBag.var3 = arr;
            ViewBag.var4 = new List<string>(){"apple","banana","mango"};

            Employee employee= new Employee();
            employee.Name = "Hasan";
            employee.Designation = "Manager";
            employee.City = "Dhaka";

            ViewBag.var5 = employee;
            return View();
        }
    }
}
