using System;
using Payroll_DAL;
using Payroll_Entity;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Payroll_BL
{
    public interface IEmployeeBL
    {
        IEnumerable<EmployeeDesigination> GetDesgination();
        IEnumerable<Employee> GetEmployee();
        void AddEmployeedata(Employee employee);
        void AddAccount(Account account);
        string GetPassword(string EmployeeName, string PhoneNumber);
        void DeleteEmployee(int EmployeeId);
        Employee GetEmployeeId(int EmployeeId);
        void UpdateEmployee(Employee employee);
    }
   public class Employee_BL:IEmployeeBL
    {
        EmployeeRepository repository = new EmployeeRepository();
        public void AddEmployeedata(Employee employee)
        {
            repository.AddEmployee(employee);
        }
        public IEnumerable<EmployeeDesigination> GetDesgination()
        {
            return repository.GetDesgination();
        }
        public IEnumerable<Employee> GetEmployee()
        {
            return repository.GetEmployee();
        }
        public void AddAccount(Account account)
        {
            repository.AddAccount(account);
        }
        public string GetPassword(string EmployeeName, string PhoneNumber)
        {
            return EmployeeName.Substring(0, 3) + PhoneNumber.Substring(0, 3);
        }
        public void DeleteEmployee(int EmployeeId)
        {
            repository.DeleteEmployee(EmployeeId);
        }
        public Employee GetEmployeeId(int EmployeeId)
        {
            return repository.EditEmployee(EmployeeId);
        }
        public void UpdateEmployee(Employee employee)
        {
            repository.UpdateEmployee(employee);
        }
    }
}