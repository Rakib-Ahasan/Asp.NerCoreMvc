using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StronglyTypedView_Demo.Models;

namespace StronglyTypedView_Demo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Employee employee1 = new Employee();
            employee1.Name = "ali";
            employee1.Designation = "Manager";
            employee1.City = "Rajshahi";

            Employee employee2 = new Employee();
            employee2.Name = "kamal";
            employee2.Designation = "CEO";
            employee2.City = "Khulna";

            Employee employee3 = new Employee();
            employee3.Name = "Rakib";
            employee3.Designation = "Director";
            employee3.City = "Naogaon";

            List<Employee>employeeList=new List<Employee>();
            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);
            return View(employeeList);
        }
    }
}
