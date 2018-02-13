using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCKudvenkat.Models;

namespace MVCKudvenkat.Controllers
{
    public class DemoController : Controller
    {
        EmployeeContext context = new EmployeeContext();
        // GET: Demo
        public ActionResult Index()
        {
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            employeeViewModel.employee = context.Employees.Where(emp => emp.EmployeeId == 9).SingleOrDefault();

           List<Employee> dbEmployeeList= context.Employees.ToList();
            
            employeeViewModel.employeeList = new SelectList(dbEmployeeList, "EmployeeId", "EmployeeName", employeeViewModel.employee);
            var empList= new SelectList(dbEmployeeList, "EmployeeId", "EmployeeName", employeeViewModel.employee.EmployeeId);
            ViewBag.employeeList = empList;
            employeeViewModel.employeeList2 = dbEmployeeList;
            return View(employeeViewModel);
        }

        public ActionResult Index1()
        {
            List<Employee> dbEmployeeList = context.Employees.ToList();
            ViewBag.employeeList = new SelectList(dbEmployeeList, "EmployeeId", "EmployeeName");

            return View();
        }
    }
}