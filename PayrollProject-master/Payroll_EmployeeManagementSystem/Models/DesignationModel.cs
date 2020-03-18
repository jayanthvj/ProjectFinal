using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Payroll_Entity;
using System.Web;

namespace Payroll_EmployeeManagementSystem.Models
{
    public class DesignationModel
    {
        [Display(Name = "Designation Name")]
        [Required(ErrorMessage = "Designation is Required")]
        [RegularExpression("^[A-Z][a-zA-Z]+$",ErrorMessage ="First Letter must be Capital")]
        public string Designation { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}