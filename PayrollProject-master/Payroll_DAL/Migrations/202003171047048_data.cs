namespace Payroll_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Salaries", "employee_EmployeeId", "dbo.Employees");
            DropIndex("dbo.Salaries", new[] { "employee_EmployeeId" });
            DropColumn("dbo.Salaries", "employee_EmployeeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Salaries", "employee_EmployeeId", c => c.Int());
            CreateIndex("dbo.Salaries", "employee_EmployeeId");
            AddForeignKey("dbo.Salaries", "employee_EmployeeId", "dbo.Employees", "EmployeeId");
        }
    }
}
