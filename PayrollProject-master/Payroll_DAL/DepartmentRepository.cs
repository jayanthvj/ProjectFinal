using System;
using System.Collections.Generic;
using System.Linq;
using Payroll_Entity;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Payroll_DAL
{
    public class DepartmentRepository
    {
        ContextClass contextClass = new ContextClass();
        public void AddDepartment(Department department)
        {
            SqlParameter sql = new SqlParameter("@DepartmentName", department.DepartmentName);
            var data = contextClass.Database.ExecuteSqlCommand("Department_Insert @DepartmentName", sql);
            //contextClass.departments.Add(department);
            contextClass.SaveChanges();
        }
        public IEnumerable<Department> GetDepartment()
        {

            return contextClass.departments.ToList();
        }
        public void DeleteDepartment(int DepartmentId)
        {
            using (ContextClass departmentContextClass = new ContextClass())
            {
                SqlParameter sql = new SqlParameter("@DepartmentId", DepartmentId);
               int count = contextClass.Database.ExecuteSqlCommand("Department_Delete @DepartmentId", sql);
                //Department department = departmentContextClass.departments.Find(DepartmentId);
                //departmentContextClass.departments.Remove(department);
                departmentContextClass.SaveChanges();
            }
        }
    }

}
