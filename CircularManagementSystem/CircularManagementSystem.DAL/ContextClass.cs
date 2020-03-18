using CircularManagementSystem.Entity;
using System.Data.Entity;
namespace CircularManagementSystem.DAL
{
    class ContextClass:DbContext
    {
        public ContextClass():base("connectionString")
        {

        }
        public DbSet<Department> departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
