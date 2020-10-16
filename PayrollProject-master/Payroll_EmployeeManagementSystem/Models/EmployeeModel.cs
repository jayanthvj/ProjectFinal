using Payroll_Entity;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Payroll_EmployeeManagementSystem.Models
{
    public class EmployeeModel
    {
        //EmployeeId Field
        public int EmployeeId { get; set; }

        //Name Field
        [Display(Name = "Name")]
        [Required(ErrorMessage =" Name is Required")]
        [RegularExpression("^[A-Z][a-zA-Z]+$",ErrorMessage ="First letter must be Capital letter")]
        public string EmployeeName { get; set; }

        //Age Field
        [Display(Name = "Age")]
        [Range (18,56,ErrorMessage ="Age Must be between 18 to 56")]
        [Required(ErrorMessage = "please fill the data")]
        public byte EmployeeAge { get; set; }

        //Designation ID Field
        [Required (ErrorMessage ="please select the Designation")]
        public int DesignationId { get; set; }
        public EmployeeDesigination Designation { get; set; }

        //EmailId Field
        [Display(Name = "EmailId")]
        [Required(ErrorMessage ="Email is Required")]
        [RegularExpression("[a-z]+@[a-z]+.[a-z]{3,6}",ErrorMessage ="Enter the correct EmailID")]
        public string EmailId { get; set; }

        //Mobile Number Field
        [Display(Name = "Mobile Number")]
        [RegularExpression("^[1-9]{1}[0-9]{9}$",ErrorMessage ="Enter the correct number")]
        [Required(ErrorMessage = "Mobile Number is required")]
        public long PhoneNumber { get; set; }

        //Gender Field
        [Display(Name = "Gender")]
        [RegularExpression("^[a-zA-Z]{1}[a-z]{3}$",ErrorMessage ="Enter the gender")]
        [Required(ErrorMessage = "please enter the gender")]
        public string Gender { get; set; }

        //DepartmentId Field
        [Required (ErrorMessage ="please select the department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}