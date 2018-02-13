using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCKudvenkat.Models;
using System.Web.Mvc;

namespace MVCKudvenkat.Models
{
    public class EmployeeViewModel
    {
        //public Employee employee { get; set; }
        public Employee employee { get; set; }
        public SelectList employeeList { get; set; }
        public List<Employee> employeeList2 { get; set; }
        //public IEnumerable<SelectListItem> EmployeeDropDownSelectedValue { get; set; }
    }
}