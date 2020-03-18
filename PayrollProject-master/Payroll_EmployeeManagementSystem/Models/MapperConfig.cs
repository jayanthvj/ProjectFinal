using System;
using System.Collections.Generic;
using System.Linq;
using Payroll_Entity;

namespace Payroll_EmployeeManagementSystem.Models
{
    public class MapperConfig
    {
        public static void Mapperdata()
        {
            AutoMapper.Mapper.Initialize(config =>
            {
                //Mapper config for employee entity
                config.CreateMap<EmployeeModel, Employee>();
            });
        }
    }
}