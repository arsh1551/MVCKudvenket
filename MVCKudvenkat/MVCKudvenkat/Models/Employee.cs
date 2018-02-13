using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCKudvenkat.Models
{
    [Table("tblEmployee")]
    public class Employee
    { 
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public Decimal EmployeeSalary { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
            
    }
}