using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace CircularManagementSystem.Entity
{
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity),Key()]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        [ForeignKey("DepartmentRefId")]
        public ICollection<Employee> Employees { get; set; }
    }
}
