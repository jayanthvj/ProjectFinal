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
        [MaxLength(20)]
        public string Role { get; set; }
        [Key]
        [MaxLength(250)]
        [Index(IsUnique = true)]
        public string EmailId { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }
        public Employee employee { get; set; }
    }
}
