using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Payroll_Entity
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int EmployeeId { get; set; }
        [MaxLength(50)]
        [Index(IsUnique =true)]
        public string EmployeeName { get; set; }
        public byte EmployeeAge { get; set; }
        public int DesignationId { get; set; }
        public EmployeeDesigination Designation { get; set; }
        [MaxLength(250)]
        [Index(IsUnique = true)]
        public string EmailId { get; set; }
        public long PhoneNumber { get; set; }
        [MaxLength(6)]
        public string Gender { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
