using System;
using System.Collections.Generic;
using Payroll_Entity;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Payroll_DAL
{
   public class EmployeeRepository
    {
        ContextClass EmployeeContextClass = new ContextClass();
        public void AddEmployee(Employee employee)
        {
            EmployeeContextClass.Employees.Add(employee);
            EmployeeContextClass.SaveChanges();
        }
        public IEnumerable<EmployeeDesigination> GetDesgination()
        {
            using (ContextClass EmployeeContextClass = new ContextClass())
            {
                return EmployeeContextClass.Designation.ToList();
            }
        }
        public IEnumerable<Employee> GetEmployee()
        {
            using (ContextClass EmployeeContextClass = new ContextClass())
            {
                return EmployeeContextClass.Employees.Include("Department").Include("Designation").ToList();
            }
        }
        public void AddAccount(Account account)
        {
            EmployeeContextClass.Account.Add(account);
            EmployeeContextClass.SaveChanges();
        }
        public void DeleteEmployee(int EmployeeId)
        {
            using (ContextClass EmployeeContextClass = new ContextClass())
            {
                Employee employee = EmployeeContextClass.Employees.Find(EmployeeId);
                EmployeeContextClass.Employees.Remove(employee);
                EmployeeContextClass.SaveChanges();
            }
        }
        public Employee EditEmployee(int EmployeeId)
        {
            using (ContextClass EmployeeContextClass = new ContextClass())
            {
                return EmployeeContextClass.Employees.Find(EmployeeId);
            }

        }

        public void UpdateEmployee(Employee employee)
        {
            using (ContextClass EmployeeContextClass = new ContextClass())
            {
                Employee findEmployee= EditEmployee(employee.EmployeeId);
                EmployeeContextClass.Entry(findEmployee).State = System.Data.Entity.EntityState.Modified;
                EmployeeContextClass.SaveChanges();
            }
        }
        public Account CheckLogin(Account account)
        {
            using (ContextClass EmployeeContextClass = new ContextClass())
            {
                Account user = EmployeeContextClass.Account.Where(u => u.EmailId == account.EmailId && u.Password == account.Password).SingleOrDefault();
                if (user != null)
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }

        }
    }
}
