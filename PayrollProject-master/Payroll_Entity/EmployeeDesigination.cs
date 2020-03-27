using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Payroll_Entity
{
    public class EmployeeDesigination
    {
        [Key]
        public int DesignationId { get; set; }
        [MaxLength(50)]
        public string Designation{ get; set; }
    }
}
