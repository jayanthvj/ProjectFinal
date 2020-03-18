using CircularManagementSystem.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CircularManagementSystem.DAL
{
    public class DepartmentRepository
    {
        ContextClass contextClass = new ContextClass();
        public void AddDepartment(Department department)
        {
            contextClass.departments.Add(department);
            contextClass.SaveChanges();
        }
        public IEnumerable<Department> GetDepartment()
        {
            List<SelectListItem> departmentList = (from p in contextClass.departments.AsEnumerable()
                                                 select new SelectListItem
                                                 {
                                                     Text = p.DepartmentName,
                                                     Value = p.DepartmentId.ToString()
                                                 }).ToList();

            //Add Default Item at First Position.
            departmentList.Insert(0, new SelectListItem { Text = "--Select Customer--", Value = "" });
            return contextClass.departments.ToList();
        }
    }
    
}
