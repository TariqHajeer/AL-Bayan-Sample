using StoreakApiService.Core.Context.DataModel;
using System;
using System.Collections.Generic;

namespace Storeak.Demo.Api.Infrastructure.DataModel
{
    public class EmployeeDto : TrackableDto
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public int Age { get; set; }
        public EmployeeTypes Type { get; set; }
    }
}
