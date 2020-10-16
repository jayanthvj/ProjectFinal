using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Entity
{
   public class Account
    {

       [Key]
        public string EmailId { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public Employee employee { get; set; }
    }
}
