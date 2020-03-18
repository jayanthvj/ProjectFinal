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
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().MapToStoredProcedures();
            modelBuilder.Entity<EmployeeDesigination>().MapToStoredProcedures();
        }
        public DbSet<Department> departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeDesigination> Designation { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<Salary> Salary { get; set; }
    }
}
