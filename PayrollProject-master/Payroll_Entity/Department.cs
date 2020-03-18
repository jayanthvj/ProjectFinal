using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Payroll_Entity
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [MaxLength(50)]
        [Index(IsUnique = true)]
        public string DepartmentName { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}
