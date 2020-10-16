using System;
using System.Collections.Generic;
using Payroll_Entity;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Data.SqlClient;

namespace Payroll_DAL
{                 
   public class EmployeeRepository
    {

        public void AddEmployee(Employee employee)      //storing data to database
        {
            using (ContextClass EmployeeContextClass = new ContextClass())
            {
                //SqlParameter EmpName = new SqlParameter("@EmployeeName",employee.EmployeeName);
                //SqlParameter EmpAge = new SqlParameter("@EmployeeAge", employee.EmployeeName);
                //SqlParameter DesignationId = new SqlParameter("@DesignationId", employee.EmployeeName);
                //SqlParameter EmailID = new SqlParameter("@EmailId", employee.EmployeeName);
                //SqlParameter PhoneNumber = new SqlParameter("@PhoneNumber", employee.EmployeeName);
                //SqlParameter Gender = new SqlParameter("@Gender", employee.EmployeeName);
                //SqlParameter DepartmentId = new SqlParameter("@DepartmentId", employee.EmployeeName);
                //int count = EmployeeContextClass.Database.ExecuteSqlCommand("Employee_Insert @EmployeeName,@EmployeeAge,@DesignationId,@EmailId,@PhoneNumber,@Gender,@DepartmentId",EmpName,EmpAge,DesignationId,EmailID,PhoneNumber,Gender,DepartmentId );
                EmployeeContextClass.Employees.Add(employee);
                EmployeeContextClass.SaveChanges();
        }
        }
        public IEnumerable<EmployeeDesigination> GetDesgination()   //getting data from database to display
        {
            using (ContextClass EmployeeContextClass = new ContextClass())
            {
                return EmployeeContextClass.Designation.ToList();
            }
        }
        public IEnumerable<Employee> GetEmployee()                //getting data from database to display
        {
            using (ContextClass EmployeeContextClass = new ContextClass())
            {
                return EmployeeContextClass.Employees.Include("Department").Include("Designation").ToList();
            }
        }
        public void AddAccount(Account account)            //storing data to database
        {
            using (ContextClass EmployeeContextClass = new ContextClass())
            {
                EmployeeContextClass.Account.Add(account);
                EmployeeContextClass.SaveChanges();
            }
        }
        public void DeleteEmployee(int EmployeeId)        //deleting the data in database
        {
            using (ContextClass EmployeeContextClass = new ContextClass())
            {
                Employee employee = EmployeeContextClass.Employees.Find(EmployeeId);
                EmployeeContextClass.Employees.Remove(employee);
                EmployeeContextClass.SaveChanges();
            }
        }
        public Employee EditEmployee(int EmployeeId)        //editing the data
        {
            using (ContextClass EmployeeContextClass = new ContextClass())
            {
                return EmployeeContextClass.Employees.Find(EmployeeId);
            }

        }

        public void UpdateEmployee(Employee employee)        //updating the data
        {
            using (ContextClass EmployeeContextClass = new ContextClass())
            {
                Employee findEmployee= EditEmployee(employee.EmployeeId);
                EmployeeContextClass.Entry(findEmployee).State = System.Data.Entity.EntityState.Modified;
                EmployeeContextClass.SaveChanges();
            }
        }
        public Account CheckLogin(Account account)           //checking the login user data with database
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
