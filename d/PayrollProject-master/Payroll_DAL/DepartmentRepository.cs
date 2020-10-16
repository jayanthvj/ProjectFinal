using System;
using System.Collections.Generic;
using System.Linq;
using Payroll_Entity;
using System.Threading.Tasks;

namespace Payroll_DAL
{
    public class DepartmentRepository
    {
        ContextClass contextClass = new ContextClass();
        public void AddDepartment(Department department)
        {
            contextClass.departments.Add(department);
            contextClass.SaveChanges();
        }
        public IEnumerable<Department> GetDepartment()
        {

            return contextClass.departments.ToList();
        }
    }

}
