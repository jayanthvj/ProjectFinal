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
        [Range(1000,500000,ErrorMessage ="the range must be within 1000 to 500000" )]
        [Required(ErrorMessage = "Please enter the salary")]
        public double BasicSalary { get; set; }

        //HRA field
        [Range(1000, 100000, ErrorMessage = "the range must be halfoff the salary")]
        [Required(ErrorMessage = "please enter the HRA")]
        public double HouseRentAllowance { get; set; }

        //Medical allowance
        [Range(1000, 50000, ErrorMessage = "the range must be within 1000 to 50000")]
        [Required(ErrorMessage = "please enter the Medical Allowance")]
        public double MedicalAllowance { get; set; }

        //PF field

        [Required(ErrorMessage = "please enter the PF")]
        public double ProvidentFund { get; set; }

    }
}