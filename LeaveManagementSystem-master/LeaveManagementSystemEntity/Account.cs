﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementSystemEntity
{
    public class Account
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
       
    }
}
