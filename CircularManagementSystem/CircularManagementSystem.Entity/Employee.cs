using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CircularManagementSystem.Entity
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity),Key()]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePhoneNumber { get; set; }
        public string EmployeeEmail { get; set; }
        public string DepartmentName { get; set; }
        public string Manager_Id { get; set; }
        public string EmployeeDesignation { get; set; }
        public string EmployeeGender { get; set; }
        public int DepartmentRefId { get; set; }
        public Department Department { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
