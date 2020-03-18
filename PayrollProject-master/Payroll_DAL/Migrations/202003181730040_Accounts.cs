namespace Payroll_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Accounts : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Accounts", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Accounts", new[] { "EmployeeId" });
            RenameColumn(table: "dbo.Accounts", name: "EmployeeId", newName: "employee_EmployeeId");
            AlterColumn("dbo.Accounts", "employee_EmployeeId", c => c.Int());
            CreateIndex("dbo.Accounts", "employee_EmployeeId");
            AddForeignKey("dbo.Accounts", "employee_EmployeeId", "dbo.Employees", "EmployeeId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "employee_EmployeeId", "dbo.Employees");
            DropIndex("dbo.Accounts", new[] { "employee_EmployeeId" });
            AlterColumn("dbo.Accounts", "employee_EmployeeId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Accounts", name: "employee_EmployeeId", newName: "EmployeeId");
            CreateIndex("dbo.Accounts", "EmployeeId");
            AddForeignKey("dbo.Accounts", "EmployeeId", "dbo.Employees", "EmployeeId", cascadeDelete: true);
        }
    }
}
