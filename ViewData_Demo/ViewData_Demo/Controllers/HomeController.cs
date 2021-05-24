using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewData_Demo.Models;

namespace ViewData_Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["var1"] = "Message comes from viewData.";
            ViewData["var2"] = DateTime.Now.ToLongDateString();
            string[] myarr = {"apple", "banana", "grapes"};
            ViewData["var3"] = myarr;
            ViewData["var4"]=new List<string>(){"cricket","football","hockey"};

            Student student = new Student();
            student.Name = "Rakib";
            student.Gender = "Male";
            student.Standard = 12;
            ViewData["var5"] = student;
            return View();
        }
    }
}
