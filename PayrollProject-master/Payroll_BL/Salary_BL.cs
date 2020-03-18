using System;
using System.Collections.Generic;
using System.Linq;
using Payroll_Entity;
using Payroll_DAL;

namespace Payroll_BL
{
   public class Salary_BL
    {
        SalaryRepository salaryRepository = new SalaryRepository();

        public void AddSalary(Salary salary)
        {
            salaryRepository.AddSalary(salary);
        }
        public IEnumerable<Salary> GetSalaryData()
        {
            return salaryRepository.GetSalaryData();
        }
        public void DeleteSalaryData(int grade)
        {
            salaryRepository.DeleteSalaryData(grade);
        }
    }
}
