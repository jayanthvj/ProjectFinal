using System;
using Payroll_BL;
using Payroll_Entity;
using Payroll_EmployeeManagementSystem.Models;
using System.Web.Mvc;

namespace Payroll_EmployeeManagementSystem.Controllers
{
    public class MainController : Controller
    {
        Department_BL department_BL = new Department_BL();
        Employee_BL employee_BL = new Employee_BL();
        Employee employee = new Employee();
        [HttpGet]
        public ActionResult AddDepartment()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDepartment(DepartmentModel departmentModel)
        {
            
            if (ModelState.IsValid)
            {
                Department department = new Department();
                department.DepartmentName = departmentModel.DepartmentName;
                department_BL.AddDepartment(department);
            }
            return View();
        }
        public ActionResult AddEmployee()
        {

            ViewBag.Designations = new SelectList(employee_BL.GetDesgination(), "DesignationId", "Designation");
            ViewBag.Departments = new SelectList(department_BL.GetDepartment(), "DepartmentId", "DepartmentName");
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(EmployeeModel employeeModel)
        {
            ViewBag.Designations = new SelectList(employee_BL.GetDesgination(), "DesignationId", "Designation");
            ViewBag.Departments = new SelectList(department_BL.GetDepartment(), "DepartmentId", "DepartmentName");

            Employee employee = new Employee();
                employee.EmployeeName = employeeModel.EmployeeName;
                employee.DesignationId = employeeModel.DesignationId;
                employee.EmailId = employeeModel.EmailId;
                employee.EmployeeAge = employeeModel.EmployeeAge;
                employee.PhoneNumber = employeeModel.PhoneNumber;
                employee.Gender = employeeModel.Gender;
                employee.DepartmentId = employeeModel.DepartmentId;
                //employee.Grade = employeeModel.Grade;
                employee_BL.AddEmployeedata(employee);
            return View();
        }

        public void Account(EmployeeModel employeeModel)
        {
                Account account = new Account();
                account.EmailId = employeeModel.EmailId;
            account.Password = employee_BL.GetPassword(employeeModel.EmployeeName,Convert.ToString( employeeModel.PhoneNumber));
                account.Role = "user";
                employee_BL.AddAccount(account);
          
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Employee employee)
        {
            return View();
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
        public ViewResult Edit(int id)
        {
            ViewBag.Designations = new SelectList(employee_BL.GetDesgination(), "DesignationId", "Designation");
            ViewBag.Departments = new SelectList(department_BL.GetDepartment(), "DepartmentId", "DepartmentName");
            EmployeeModel employeeModel = new EmployeeModel();
            employee = employee_BL.GetEmployeeId(id);
            employee.EmployeeName = employeeModel.EmployeeName;
            employee.DesignationId = employeeModel.DesignationId;
            employee.EmailId = employeeModel.EmailId;
            employee.EmployeeAge = employeeModel.EmployeeAge;
            employee.PhoneNumber = employeeModel.PhoneNumber;
            employee.Gender = employeeModel.Gender;
            employee.DepartmentId = employeeModel.DepartmentId;

            return View(employeeModel);
        }
        [HttpPost]
        public ActionResult Update(EmployeeModel employeeModel)
        {
            if (ModelState.IsValid)
            {
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
    }
}