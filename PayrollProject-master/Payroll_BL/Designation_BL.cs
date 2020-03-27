using System;
using System.Collections.Generic;
using Payroll_Entity;
using Payroll_DAL;
using System.Threading.Tasks;

namespace Payroll_BL
{
    //public interface IDesignation_Bl
    //{
    //    void AddDesignation(EmployeeDesigination designation);
    //    IEnumerable<EmployeeDesigination> GetDesignation();
    //    void DeleteDesignation(int DesignationId);
    //}
   public class Designation_BL//:IDesignation_Bl
    {
        DesignationRepository repository = new DesignationRepository();
        public void AddDesignation(EmployeeDesigination designation)
        {
           
                repository.AddDesignation(designation);
            
        }
        public IEnumerable<EmployeeDesigination> GetDesignation()
        {
            return repository.GetDesignation();
        }
        public void DeleteDesignation(int DesignationId)
        {
            repository.DeleteDesignation(DesignationId);
        }
    }
}
