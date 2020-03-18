using CircularManagementSystem.BL;
using CircularManagementSystem.Entity;
using CircularManagementSystem.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CircularManagementSystem.Controllers
{
    public class IndexController : Controller
    {
        DepartmentBL departmentBL = new DepartmentBL();
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddDepartment()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDepartment(DepartmentModel departmentModel)
        {
            if(ModelState.IsValid)
            {
                Department department = new Department();
                department.DepartmentName = departmentModel.DepartmentName;
                departmentBL.AddDepartment(department);
            }
            return View();
        }
        [HttpGet]
        public ActionResult AddEmployee()
        {
            ViewBag.Department =(IEnumerable<Department>) departmentBL.GetDepartment();
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}