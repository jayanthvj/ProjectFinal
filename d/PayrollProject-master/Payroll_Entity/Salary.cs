using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Entity
{
   public class Salary
    {
        [Key]
        public int Grade { get; set; }
        public double BasicSalary { get; set; }
        public double Allowance { get; set; }
    }
}
