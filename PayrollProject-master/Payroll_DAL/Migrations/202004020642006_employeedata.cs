namespace Payroll_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class employeedata : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
                "dbo.Employee_Insert",
                p => new
                    {
                        EmployeeName = p.String(maxLength: 50),
                        EmployeeAge = p.Byte(),
                        DesignationId = p.Int(),
                        EmailId = p.String(maxLength: 250),
                        PhoneNumber = p.Long(),
                        Gender = p.String(maxLength: 6),
                        DepartmentId = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Employees]([EmployeeName], [EmployeeAge], [DesignationId], [EmailId], [PhoneNumber], [Gender], [DepartmentId])
                      VALUES (@EmployeeName, @EmployeeAge, @DesignationId, @EmailId, @PhoneNumber, @Gender, @DepartmentId)
                      
                      DECLARE @EmployeeId int
                      SELECT @EmployeeId = [EmployeeId]
                      FROM [dbo].[Employees]
                      WHERE @@ROWCOUNT > 0 AND [EmployeeId] = scope_identity()
                      
                      SELECT t0.[EmployeeId]
                      FROM [dbo].[Employees] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[EmployeeId] = @EmployeeId"
            );
            
            CreateStoredProcedure(
                "dbo.Employee_Update",
                p => new
                    {
                        EmployeeId = p.Int(),
                        EmployeeName = p.String(maxLength: 50),
                        EmployeeAge = p.Byte(),
                        DesignationId = p.Int(),
                        EmailId = p.String(maxLength: 250),
                        PhoneNumber = p.Long(),
                        Gender = p.String(maxLength: 6),
                        DepartmentId = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Employees]
                      SET [EmployeeName] = @EmployeeName, [EmployeeAge] = @EmployeeAge, [DesignationId] = @DesignationId, [EmailId] = @EmailId, [PhoneNumber] = @PhoneNumber, [Gender] = @Gender, [DepartmentId] = @DepartmentId
                      WHERE ([EmployeeId] = @EmployeeId)"
            );
            
            CreateStoredProcedure(
                "dbo.Employee_Delete",
                p => new
                    {
                        EmployeeId = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Employees]
                      WHERE ([EmployeeId] = @EmployeeId)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.Employee_Delete");
            DropStoredProcedure("dbo.Employee_Update");
            DropStoredProcedure("dbo.Employee_Insert");
        }
    }
}
