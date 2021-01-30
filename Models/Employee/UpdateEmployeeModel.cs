using Storeak.Demo.Api.Infrastructure.DataModel;
using StoreakApiService.Core.Attributes;
using System;

namespace Storeak.Models.Demo.BusinessUseCases.Employee
{
    public class UpdateEmployeeModel
    {
        [RequiredValue(ErrorMessage = "EmployeeNameRequired")]
        public string Name { get; set; }
        public string FatherName { get; set; }
        [RequiredRange(18, 50, ErrorMessage = "EmployeeAgeRequired")]
        public int Age { get; set; }
        [RequiredValue(ErrorMessage = "EmployeeTypeRequired")]
        public EmployeeTypes Type { get; set; }
    }
}
