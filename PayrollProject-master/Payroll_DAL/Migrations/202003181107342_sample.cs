namespace Payroll_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sample : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "EmployeeAge", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "EmployeeAge", c => c.Short(nullable: false));
        }
    }
}
