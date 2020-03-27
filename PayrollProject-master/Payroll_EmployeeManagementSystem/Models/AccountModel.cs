using System;
using Payroll_Entity;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Payroll_EmployeeManagementSystem.Models
{
    public enum Role
    {
        Admin,
        User,
        AccountManager,
    }
    public class AccountModel
    {
        [Required(ErrorMessage ="Please Emter Your UserName")]
        public string EmailId { get; set; }
        [Required (ErrorMessage ="Please Enter the Password")]
        public string Password { get; set; }
        public Employee employee { get; set; }
        public Role Role { get; set; }
    }
}