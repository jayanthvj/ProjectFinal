using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Payroll_Entity;
using System.Web;

namespace Payroll_EmployeeManagementSystem.Models
{
    public class DepartmentModel
    {

        [Required]
        public string DepartmentName { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}