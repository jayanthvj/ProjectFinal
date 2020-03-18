namespace Payroll_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class unique : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String(maxLength: 50));
            AlterColumn("dbo.EmployeeDesiginations", "Designation", c => c.String(maxLength: 50));
            CreateIndex("dbo.Departments", "DepartmentName", unique: true);
            CreateIndex("dbo.EmployeeDesiginations", "Designation", unique: true);
            AlterStoredProcedure(
                "dbo.Department_Insert",
                p => new
                    {
                        DepartmentName = p.String(maxLength: 50),
                    },
                body:
                    @"INSERT [dbo].[Departments]([DepartmentName])
                      VALUES (@DepartmentName)
                      
                      DECLARE @DepartmentId int
                      SELECT @DepartmentId = [DepartmentId]
                      FROM [dbo].[Departments]
                      WHERE @@ROWCOUNT > 0 AND [DepartmentId] = scope_identity()
                      
                      SELECT t0.[DepartmentId]
                      FROM [dbo].[Departments] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[DepartmentId] = @DepartmentId"
            );
            
            AlterStoredProcedure(
                "dbo.Department_Update",
                p => new
                    {
                        DepartmentId = p.Int(),
                        DepartmentName = p.String(maxLength: 50),
                    },
                body:
                    @"UPDATE [dbo].[Departments]
                      SET [DepartmentName] = @DepartmentName
                      WHERE ([DepartmentId] = @DepartmentId)"
            );
            
            AlterStoredProcedure(
                "dbo.EmployeeDesigination_Insert",
                p => new
                    {
                        Designation = p.String(maxLength: 50),
                    },
                body:
                    @"INSERT [dbo].[EmployeeDesiginations]([Designation])
                      VALUES (@Designation)
                      
                      DECLARE @DesignationId int
                      SELECT @DesignationId = [DesignationId]
                      FROM [dbo].[EmployeeDesiginations]
                      WHERE @@ROWCOUNT > 0 AND [DesignationId] = scope_identity()
                      
                      SELECT t0.[DesignationId]
                      FROM [dbo].[EmployeeDesiginations] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[DesignationId] = @DesignationId"
            );
            
            AlterStoredProcedure(
                "dbo.EmployeeDesigination_Update",
                p => new
                    {
                        DesignationId = p.Int(),
                        Designation = p.String(maxLength: 50),
                    },
                body:
                    @"UPDATE [dbo].[EmployeeDesiginations]
                      SET [Designation] = @Designation
                      WHERE ([DesignationId] = @DesignationId)"
            );
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.EmployeeDesiginations", new[] { "Designation" });
            DropIndex("dbo.Departments", new[] { "DepartmentName" });
            AlterColumn("dbo.EmployeeDesiginations", "Designation", c => c.String());
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String());
            throw new NotSupportedException("Scaffolding create or alter procedure operations is not supported in down methods.");
        }
    }
}
