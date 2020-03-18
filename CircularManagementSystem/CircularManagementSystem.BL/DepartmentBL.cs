using CircularManagementSystem.Entity;
using CircularManagementSystem.DAL;
using System.Collections.Generic;

namespace CircularManagementSystem.BL
{
    public class DepartmentBL
    {
        DepartmentRepository repository = new DepartmentRepository();
        public void AddDepartment(Department department)
        {
            repository.AddDepartment(department);
        }
        public IEnumerable<Department> GetDepartment()
        {
            return repository.GetDepartment();
        }
    }
}
