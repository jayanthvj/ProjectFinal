using System;
using Payroll_BL;
using Payroll_Entity;
using Payroll_EmployeeManagementSystem.Models;
using System.Web.Mvc;
using System.Collections.Generic;

namespace Payroll_EmployeeManagementSystem.Controllers
{

    [Authorize(Roles = "Admin,Account Manager")]
    public class MainController : Controller
    {
        Designation_BL designation_BL = new Designation_BL();
        Department_BL department_BL = new Department_BL();                           //Object for Department Business layer
        Salary_BL salary_BL = new Salary_BL();                                       //Object for Salary Business layer
        Employee employee = new Employee();                                          //Object for Employee Entity
        Department department = new Department();                                    //Object for Department Entity
        EmployeeDesigination designation = new EmployeeDesigination();               //Object for Designation Entity
        EmployeeModel employeeModel = new EmployeeModel();                           //Object for Employee Model
        Account account = new Account();                                             //Object for Account Entity
        Salary salary = new Salary();                                                //Object for Salary Entity
        //IDesignation_Bl designation_BL;
        IEmployeeBL employee_BL;
        public MainController()
        {
            employee_BL = new Employee_BL();
            //designation_BL = new Designation_BL();
            
        }
        public ActionResult Exception()
        {
            throw new Exception("suma error");
        }

        //Department methods
        [HttpGet]
        public ActionResult AddDepartment()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddDepartment(DepartmentModel departmentModel)
        {

            if (ModelState.IsValid)
            {

                department.DepartmentName = departmentModel.DepartmentName;
                department_BL.AddDepartment(department);
            }
            return View();
        }
        public ActionResult DisplayDepartment()
        {
            IEnumerable<Department> department = department_BL.GetDepartment();
            return View(department);
        }
        public ActionResult DeleteDepartment(int id)
        {
            department_BL.DeleteDepartment(id);
            return RedirectToAction("DisplayDepartment");
        }

        //Designation methods
      
        public ActionResult AddDesignation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDesignation(DesignationModel designationModel)
        {
                designation.Designation = designationModel.Designation;
                designation_BL.AddDesignation(designation);
                return View();
        }
        public ActionResult DisplayDesignation()
        {
            IEnumerable<EmployeeDesigination> designation = designation_BL.GetDesignation();
            return View(designation);
        }
        public ActionResult DeleteDesignation(int id)
        {
            designation_BL.DeleteDesignation(id);
            return RedirectToAction("DisplayDesignation");
        }
       

        //Employee Methods
        public ActionResult AddEmployee()
        {

            ViewBag.Designations = new SelectList(designation_BL.GetDesignation(), "DesignationId", "Designation");
            ViewBag.Departments = new SelectList(department_BL.GetDepartment(), "DepartmentId", "DepartmentName");
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(EmployeeModel employeeModel)
        {
            ViewBag.Designations = new SelectList(designation_BL.GetDesignation(), "DesignationId", "Designation");
            ViewBag.Departments = new SelectList(department_BL.GetDepartment(), "DepartmentId", "DepartmentName");
            var employee = AutoMapper.Mapper.Map<EmployeeModel, Employee>(employeeModel);
            Account(employeeModel);
            employee_BL.AddEmployeedata(employee);
            return View();
        }

        //Employee Login Account Data
        public void Account(EmployeeModel employeeModel)
        {
            //account.EmployeeId = employeeModel.EmployeeId;
            account.EmailId = employeeModel.EmailId;
            account.Password = employee_BL.GetPassword(employeeModel.EmployeeName, Convert.ToString(employeeModel.PhoneNumber));
            account.Role = Role.User.ToString();
            employee_BL.AddAccount(account);
        }
        public ActionResult Display()
        {
            TempData["Employees"] = employee_BL.GetEmployee();
            return View();
        }
        public ActionResult Delete(int id)
        {
            employee_BL.DeleteEmployee(id);
            return RedirectToAction("Display");
        }
        public ViewResult Edit(int Id)
        {
            ViewBag.Designations = new SelectList(employee_BL.GetDesgination(), "DesignationId", "Designation");
            ViewBag.Departments = new SelectList(department_BL.GetDepartment(), "DepartmentId", "DepartmentName");
            employee = employee_BL.GetEmployeeId(Id);
            employeeModel.EmployeeId = employee.EmployeeId;
            employeeModel.EmployeeName = employee.EmployeeName;
            employeeModel.DesignationId = employee.DesignationId;
            employeeModel.EmailId = employee.EmailId;
            employeeModel.EmployeeAge = employee.EmployeeAge;
            employeeModel.PhoneNumber = employee.PhoneNumber;
            employeeModel.Gender = employee.Gender;
            employeeModel.DepartmentId = employee.DepartmentId;
            return View(employeeModel);
        }
        [HttpPost]
        public ActionResult Update(EmployeeModel employeeModel)
        {
            if (ModelState.IsValid)
            {
                employee.EmployeeId = employeeModel.EmployeeId;
                employee.EmployeeName = employeeModel.EmployeeName;
                employee.DesignationId = employeeModel.DesignationId;
                employee.EmailId = employeeModel.EmailId;
                employee.EmployeeAge = employeeModel.EmployeeAge;
                employee.PhoneNumber = employeeModel.PhoneNumber;
                employee.Gender = employeeModel.Gender;
                employee.DepartmentId = employeeModel.DepartmentId;
                employee_BL.UpdateEmployee(employee);
                return RedirectToAction("Display");
            }
            return View();
        }

         //Employee salary methods
        public ActionResult SalaryData()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SalaryData(SalaryDataModel salaryData)
        {

            if (ModelState.IsValid)
            {

                salary.BasicSalary = salaryData.BasicSalary;
                salary.HouseRentAllowance = salaryData.HouseRentAllowance;
                salary.MedicalAllowance = salaryData.MedicalAllowance;
                salary.ProvidentFund = salaryData.ProvidentFund;
                salary_BL.AddSalary(salary);
            }
            return View();
        }
        public ActionResult DisplaySalaryData()
        {
            IEnumerable<Salary> salary = salary_BL.GetSalaryData();
            return View(salary);
        }
        public ActionResult DeleteSalaryData(int grade)
        {
            salary_BL.DeleteSalaryData(grade);
            return RedirectToAction("DisplaySalaryData");
        }
       
    }
}