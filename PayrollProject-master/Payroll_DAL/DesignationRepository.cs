using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using Payroll_Entity;


namespace Payroll_DAL
{
  public  class DesignationRepository
    {
        ContextClass contextClass = new ContextClass();
        public void AddDesignation(EmployeeDesigination designation)
        {
            SqlParameter sql = new SqlParameter("@Designation", designation.Designation);
            int count = contextClass.Database.ExecuteSqlCommand("EmployeeDesigination_Insert @Designation", sql);
             //contextClass.Designation.Add(designation);
            contextClass.SaveChanges();
        }
        public IEnumerable<EmployeeDesigination> GetDesignation()
        {

            return contextClass.Designation.ToList();
        }
        public void DeleteDesignation(int DesignationId)
        {
            using (ContextClass designationContextClass = new ContextClass())
            {using (var transaction = contextClass.Database.BeginTransaction())
                {
                    try
                    {
                        SqlParameter sql = new SqlParameter("@DesignationId", DesignationId);
                        int count = contextClass.Database.ExecuteSqlCommand("EmployeeDesigination_Delete @DesignationId", sql);
                        transaction.Commit();
                    }
                    catch (System.Exception)
                    {
                        transaction.Rollback();
                    }
                }
                //EmployeeDesigination designation = designationContextClass.Designation.Find(DesignationId);
                //   designationContextClass.Designation.Remove(designation);
                //designationContextClass.SaveChanges();
            }
        }
    }
}
