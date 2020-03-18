namespace Payroll_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Account : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Accounts", "employee_EmployeeId", "dbo.Employees");
            DropIndex("dbo.Accounts", new[] { "employee_EmployeeId" });
            RenameColumn(table: "dbo.Accounts", name: "employee_EmployeeId", newName: "EmployeeId");
            AddColumn("dbo.Salaries", "employee_EmployeeId", c => c.Int());
            AlterColumn("dbo.Accounts", "EmployeeId", c => c.Int(nullable: true));
            CreateIndex("dbo.Accounts", "EmployeeId");
            CreateIndex("dbo.Salaries", "employee_EmployeeId");
            AddForeignKey("dbo.Salaries", "employee_EmployeeId", "dbo.Employees", "EmployeeId");
            AddForeignKey("dbo.Accounts", "EmployeeId", "dbo.Employees", "EmployeeId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Salaries", "employee_EmployeeId", "dbo.Employees");
            DropIndex("dbo.Salaries", new[] { "employee_EmployeeId" });
            DropIndex("dbo.Accounts", new[] { "EmployeeId" });
            AlterColumn("dbo.Accounts", "EmployeeId", c => c.Int());
            DropColumn("dbo.Salaries", "employee_EmployeeId");
            RenameColumn(table: "dbo.Accounts", name: "EmployeeId", newName: "employee_EmployeeId");
            CreateIndex("dbo.Accounts", "employee_EmployeeId");
            AddForeignKey("dbo.Accounts", "employee_EmployeeId", "dbo.Employees", "EmployeeId");
        }
    }
}
