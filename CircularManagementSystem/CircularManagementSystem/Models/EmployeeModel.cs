using CircularManagementSystem.Entity;
using System.ComponentModel.DataAnnotations;
namespace CircularManagementSystem.Models
{
    public class EmployeeModel
    {
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string EmployeePhoneNumber { get; set; }
        [Required]
        public string EmployeeEmail { get; set; }
        [Required]
        public string DepartmentName { get; set; }
        [Required]
        public string Manager_Id { get; set; }
        [Required]
        public string EmployeeDesignation { get; set; }
        [Required]
        public string EmployeeGender { get; set; }
        public int DepartmentRefId { get; set; }
        public Department Department { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}