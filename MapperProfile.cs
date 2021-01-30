using AutoMapper;
using Storeak.Demo.Api.Infrastructure.DataModel;
using Storeak.Models.Demo.BusinessUseCases.Employee;
using Storeak.Models.Demo.Queries.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storeak.Demo.Api
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<EmployeeDto, CreateEmployeeModel>().ReverseMap();
            CreateMap<EmployeeDto, GetAllEmployeeModel>().ReverseMap();
            CreateMap<EmployeeDto, GetEmployeeModel>().ReverseMap();
        }
    }
}
