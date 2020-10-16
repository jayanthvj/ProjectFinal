using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Entity
{
   public class EmployeeDesigination
    {
        [Key]
        public int DesignationId { get; set; }
        public string Designation{ get; set; }
    }
}
