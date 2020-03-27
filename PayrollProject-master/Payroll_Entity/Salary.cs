using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Entity
{
   public class Salary
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int Grade { get; set; }
        public double BasicSalary { get; set; }
        public double MedicalAllowance { get; set; }
        public double HouseRentAllowance { get; set; }
        public double ProvidentFund { get; set; }
        public Employee employee { get; set; }
    }
}
