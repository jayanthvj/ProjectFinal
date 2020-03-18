using System;
using System.Collections.Generic;
using Payroll_DAL;
using Payroll_Entity;
using System.Threading.Tasks;

namespace Payroll_BL
{
    public class Department_BL
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
        public void DeleteDepartment(int DepartmentId)
        {
            repository.DeleteDepartment(DepartmentId);
        }
    }
}
