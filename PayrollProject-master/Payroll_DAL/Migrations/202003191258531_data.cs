﻿namespace Payroll_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        EmailId = c.String(nullable: false, maxLength: 250),
                        Role = c.String(maxLength: 20),
                        Password = c.String(maxLength: 50),
                        employee_EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.EmailId)
                .ForeignKey("dbo.Employees", t => t.employee_EmployeeId)
                .Index(t => t.EmailId, unique: true)
                .Index(t => t.employee_EmployeeId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(maxLength: 50),
                        EmployeeAge = c.Byte(nullable: false),
                        DesignationId = c.Int(nullable: false),
                        EmailId = c.String(maxLength: 250),
                        PhoneNumber = c.Long(nullable: false),
                        Gender = c.String(maxLength: 6),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.EmployeeDesiginations", t => t.DesignationId, cascadeDelete: true)
                .Index(t => t.EmployeeName, unique: true)
                .Index(t => t.DesignationId)
                .Index(t => t.EmailId, unique: true)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.EmployeeDesiginations",
                c => new
                    {
                        DesignationId = c.Int(nullable: false, identity: true),
                        Designation = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.DesignationId);
            
            CreateTable(
                "dbo.Salaries",
                c => new
                    {
                        Grade = c.Int(nullable: false, identity: true),
                        BasicSalary = c.Double(nullable: false),
                        MedicalAllowance = c.Double(nullable: false),
                        HouseRentAllowance = c.Double(nullable: false),
                        ProvidentFund = c.Double(nullable: false),
                        employee_EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.Grade)
                .ForeignKey("dbo.Employees", t => t.employee_EmployeeId)
                .Index(t => t.employee_EmployeeId);
            
            CreateStoredProcedure(
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
            
            CreateStoredProcedure(
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
            
            CreateStoredProcedure(
                "dbo.Department_Delete",
                p => new
                    {
                        DepartmentId = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Departments]
                      WHERE ([DepartmentId] = @DepartmentId)"
            );
            
            CreateStoredProcedure(
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
            
            CreateStoredProcedure(
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
            
            CreateStoredProcedure(
                "dbo.EmployeeDesigination_Delete",
                p => new
                    {
                        DesignationId = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[EmployeeDesiginations]
                      WHERE ([DesignationId] = @DesignationId)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.EmployeeDesigination_Delete");
            DropStoredProcedure("dbo.EmployeeDesigination_Update");
            DropStoredProcedure("dbo.EmployeeDesigination_Insert");
            DropStoredProcedure("dbo.Department_Delete");
            DropStoredProcedure("dbo.Department_Update");
            DropStoredProcedure("dbo.Department_Insert");
            DropForeignKey("dbo.Salaries", "employee_EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Accounts", "employee_EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "DesignationId", "dbo.EmployeeDesiginations");
            DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Salaries", new[] { "employee_EmployeeId" });
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            DropIndex("dbo.Employees", new[] { "EmailId" });
            DropIndex("dbo.Employees", new[] { "DesignationId" });
            DropIndex("dbo.Employees", new[] { "EmployeeName" });
            DropIndex("dbo.Accounts", new[] { "employee_EmployeeId" });
            DropIndex("dbo.Accounts", new[] { "EmailId" });
            DropTable("dbo.Salaries");
            DropTable("dbo.EmployeeDesiginations");
            DropTable("dbo.Departments");
            DropTable("dbo.Employees");
            DropTable("dbo.Accounts");
        }
    }
}
