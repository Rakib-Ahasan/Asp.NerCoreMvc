using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _ViewImports_Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace _ViewImports_Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Student student1 = new Student {Id = 1, Name = "Sagor", Age = 22};
            Student student2 = new Student {Id = 2, Name = "Rakib", Age = 23};
            Student student3 = new Student {Id = 3, Name = "Ahasan", Age = 24};

            List<Student> studentList = new List<Student> {student1, student2, student3};
            return View(studentList);
        }

        public IActionResult Details(int id)
        {
            Student student1 = new Student { Id = id, Name = "Sagor", Age = 22 };
            return View(student1);
        }
    }
}
