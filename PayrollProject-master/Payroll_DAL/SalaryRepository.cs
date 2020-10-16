using System;
using System.Collections.Generic;
using System.Linq;
using Payroll_Entity;
using System.Threading.Tasks;

namespace Payroll_DAL
{
   public class SalaryRepository
    { 
        public void AddSalary(Salary salary)             //Storing data to database 
        {
            using (ContextClass context = new ContextClass())
                {
                context.Salary.Add(salary);
                context.SaveChanges();
            }
        }
        public IEnumerable<Salary> GetSalaryData()    //Getting data from database to display
        {
            using (ContextClass context = new ContextClass())
            {
                return context.Salary.ToList();
            }
        }
        public void DeleteSalaryData(int grade)      //deleting data in database using stored procedure
        {
            using (ContextClass context = new ContextClass())
            {
                Salary salary = context.Salary.Find(grade);
                context.Salary.Remove(salary);
                context.SaveChanges();
            }
        }
    }
}
