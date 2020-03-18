using System;
using System.Collections.Generic;
using System.Linq;
using Payroll_Entity;
using System.Threading.Tasks;

namespace Payroll_DAL
{
   public class SalaryRepository
    {
        ContextClass context = new ContextClass();

        public void AddSalary(Salary salary)
        {
            context.Salary.Add(salary);
            context.SaveChanges();
        }
        public IEnumerable<Salary> GetSalaryData()
        {

            return context.Salary.ToList();
        }
        public void DeleteSalaryData(int grade)
        {
            using (ContextClass departmentContextClass = new ContextClass())
            {
                //SqlParameter sql = new SqlParameter("@DepartmentId", DepartmentId);
                //int count = contextClass.Database.ExecuteSqlCommand("Department_Delete @DepartmentId", sql);
                Salary salary = context.Salary.Find(grade);
                context.Salary.Remove(salary);
                context.SaveChanges();
            }
        }
    }
}
