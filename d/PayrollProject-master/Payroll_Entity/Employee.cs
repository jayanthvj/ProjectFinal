using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Entity
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public short EmployeeAge { get; set; }
        public int DesignationId { get; set; }
        public EmployeeDesigination Designation { get; set; }
        public string EmailId { get; set; }
        public Account account { get; set; }
        public long PhoneNumber { get; set; }
        public string Gender { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    
        //public int Grade { get; set; }
        //public Salary salary { get; set;}
    }
}
