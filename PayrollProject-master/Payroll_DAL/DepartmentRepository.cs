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
        
        public void AddDepartment(Department department)      //storing the data to database using stored procedure
        {
            using (ContextClass contextClass = new ContextClass())
            {
                SqlParameter sql = new SqlParameter("@DepartmentName", department.DepartmentName);
                var data = contextClass.Database.ExecuteSqlCommand("Department_Insert @DepartmentName", sql);
                //contextClass.departments.Add(department);
                contextClass.SaveChanges();
            }
        }
        public IEnumerable<Department> GetDepartment()     //getting data from database to display 
        {
            using (ContextClass contextClass = new ContextClass())
            {
                return contextClass.departments.ToList();
            }
        }
        public void DeleteDepartment(int DepartmentId)      //deleting the data from database using stored procedure
        {
            using (ContextClass departmentContextClass = new ContextClass())
            {
                SqlParameter sql = new SqlParameter("@DepartmentId", DepartmentId);
               int count = departmentContextClass.Database.ExecuteSqlCommand("Department_Delete @DepartmentId", sql);
                //Department department = departmentContextClass.departments.Find(DepartmentId);
                //departmentContextClass.departments.Remove(department);
                departmentContextClass.SaveChanges();
            }
        }
    }

}
