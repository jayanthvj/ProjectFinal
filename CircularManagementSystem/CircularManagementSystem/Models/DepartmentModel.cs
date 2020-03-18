using CircularManagementSystem.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CircularManagementSystem.Models
{
    public class DepartmentModel
    {
        [Required]
        public string DepartmentName { get; set; }
        [ForeignKey("DepartmentRefId")]
        public ICollection<Employee> Employees { get; set; }
    }
}