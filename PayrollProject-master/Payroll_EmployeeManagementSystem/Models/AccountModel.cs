using System;
using Payroll_Entity;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Payroll_EmployeeManagementSystem.Models
{
    public class AccountModel
    {
        [Required(ErrorMessage ="Please Emter Your UserName")]
        public string EmailId { get; set; }
        [Required (ErrorMessage ="Please Enter the Password")]
        public string Password { get; set; }
        //public int EmployeeId { get; set; }
        public Employee employee { get; set; }
    }
}