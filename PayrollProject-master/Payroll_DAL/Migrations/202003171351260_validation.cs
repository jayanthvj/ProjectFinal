namespace Payroll_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "EmployeeName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Employees", "EmailId", c => c.String(maxLength: 250));
            AlterColumn("dbo.Employees", "Gender", c => c.String(maxLength: 6));
            CreateIndex("dbo.Employees", "EmployeeName", unique: true);
            CreateIndex("dbo.Employees", "EmailId", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Employees", new[] { "EmailId" });
            DropIndex("dbo.Employees", new[] { "EmployeeName" });
            AlterColumn("dbo.Employees", "Gender", c => c.String());
            AlterColumn("dbo.Employees", "EmailId", c => c.String());
            AlterColumn("dbo.Employees", "EmployeeName", c => c.String());
        }
    }
}
