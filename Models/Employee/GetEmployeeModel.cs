using Storeak.Demo.Api.Infrastructure.DataModel;
using StoreakApiService.Core.Attributes;
using System;

namespace Storeak.Models.Demo.Queries.Employee
{
    public class GetEmployeeModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public int Age { get; set; }
        public EmployeeTypes Type { get; set; }
    }
}
