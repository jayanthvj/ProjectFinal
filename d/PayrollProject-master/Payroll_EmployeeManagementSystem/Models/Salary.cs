using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Payroll_EmployeeManagementSystem.Models
{
    public class Salary
    {
        public int Grade { get; set; }
        public double BasicSalary { get; set; }
        public double Allowance { get; set; }
    }
}