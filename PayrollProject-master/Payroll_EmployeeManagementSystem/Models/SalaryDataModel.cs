using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Payroll_EmployeeManagementSystem.Models
{
    public class SalaryDataModel
    {
        //Basic Salary field
        [Required (ErrorMessage ="Please enter the salary")]
        public double BasicSalary { get; set; }

        //HRA field
        [Required (ErrorMessage ="please enter the HRA")]
        public double HouseRentAllowance { get; set; }

        //Medical allowance
        [Required (ErrorMessage = "please enter the Medical Allowance")]
        public double MedicalAllowance { get; set; }

        //PF field
        [Required(ErrorMessage = "please enter the PF")]
        public double ProvidentFund { get; set; }

    }
}