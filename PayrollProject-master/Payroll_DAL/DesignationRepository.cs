using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using Payroll_Entity;


namespace Payroll_DAL
{
    public class DesignationRepository
    {

        public void AddDesignation(EmployeeDesigination designation)    //storing data to database using stored procedure
        {
            using (ContextClass contextClass = new ContextClass())
            {
                SqlParameter sql = new SqlParameter("@Designation", designation.Designation);
                int count = contextClass.Database.ExecuteSqlCommand("EmployeeDesigination_Insert @Designation", sql);
                //contextClass.Designation.Add(designation);
                contextClass.SaveChanges();
            }
        }
        public IEnumerable<EmployeeDesigination> GetDesignation()    //getting data from database to display
        {
            using (ContextClass contextClass = new ContextClass())
            {
                return contextClass.Designation.ToList();
            }
        }
        public void DeleteDesignation(int DesignationId)   //deleting data in database using stored procedure
        {
            using (ContextClass contextClass = new ContextClass())
            {
                using (var transaction = contextClass.Database.BeginTransaction())
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
            }
        }
    }
}
