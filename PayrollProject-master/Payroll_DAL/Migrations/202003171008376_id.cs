namespace Payroll_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class id : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Salaries", "employee_EmployeeId", c => c.Int());
            CreateIndex("dbo.Salaries", "employee_EmployeeId");
            AddForeignKey("dbo.Salaries", "employee_EmployeeId", "dbo.Employees", "EmployeeId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Salaries", "employee_EmployeeId", "dbo.Employees");
            DropIndex("dbo.Salaries", new[] { "employee_EmployeeId" });
            DropColumn("dbo.Salaries", "employee_EmployeeId");
        }
    }
}
