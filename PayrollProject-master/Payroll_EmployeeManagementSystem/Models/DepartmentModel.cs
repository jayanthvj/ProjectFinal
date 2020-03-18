using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Payroll_Entity;
using System.Web;

namespace Payroll_EmployeeManagementSystem.Models
{
    public class DepartmentModel
    {
        //Department name filed

        [Display(Name = "Department Name")]
        [Required(ErrorMessage = "Department Name is Required")]
        [RegularExpression("^[A-Z][a-zA-Z]+$",ErrorMessage ="First Letter must be Capital")]
        public string DepartmentName { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}