using System;
using Payroll_Entity;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_DAL
{
    class ContextClass :DbContext
    {
        public ContextClass() : base("MyConnection")
        {

        }
        public DbSet<Department> departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDesigination> Designation { get; set; }
        public DbSet<Account> Account { get; set; }
    }
}
