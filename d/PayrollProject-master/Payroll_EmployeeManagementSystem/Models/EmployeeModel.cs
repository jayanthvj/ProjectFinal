using Payroll_Entity;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Payroll_EmployeeManagementSystem.Models
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
       [Required]
        public string EmployeeName { get; set; }
        [Required]
        public short EmployeeAge { get; set; }
        [Required]
        public int DesignationId { get; set; }
        public EmployeeDesigination Designation { get; set; }
        [Required]
        public string EmailId { get; set; }
        [Required]
        public long PhoneNumber { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        //[Required]
        //public int AccountId { get; set; }
        //public Account Account { get; set; }
        //[Required]
        //public int Grade { get; set; }
        //public Salary salary { get; set;}

    }
}