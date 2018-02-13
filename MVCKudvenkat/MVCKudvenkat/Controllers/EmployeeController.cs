using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCKudvenkat.Models;

namespace MVCKudvenkat.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeContext empContext = new EmployeeContext();
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> employees = empContext.Employees.ToList();

            return View(employees);
        }
    }
}