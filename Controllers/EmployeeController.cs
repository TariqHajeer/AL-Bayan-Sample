using StoreakApiService.Core.Controllers;
using StoreakApiService.Core.Responses;
using StoreakApiService.Core.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using StoreakApiService.Core.Attributes;
using Storeak.Demo.Api.Infrastructure;
using System;
using StoreakApiService.Core.Context;
using Storeak.Models.Demo.BusinessUseCases.Employee;
using System.Threading.Tasks;
using Storeak.Demo.Api.Application.BusinessUseCases.Employee;
using Storeak.Demo.Api.Application.Queries.Employee;

namespace Storeak.Demo.Api.Controllers
{
    [ControllerDocumentation("a9d1f93f-fd61-40aa-8039-d677fc4c69ea", "Demo Controller.")]
    public class EmployeeController : StoreakController
    {
        private IEmployeeService IEmployeeService { get; }
        private EmployeeQueries EmployeeQueries { get; }
        private ResponseMessages ResponsMessages { get; }

        public EmployeeController(IEmployeeService iEmployeeService, EmployeeQueries employeeQueries, IResponseMessages responsMessages)
        {
            IEmployeeService = iEmployeeService;
            EmployeeQueries = employeeQueries;
            ResponsMessages = responsMessages as ResponseMessages;
        }

        [Authorize]
        [ClaimRequirement(ClaimTypes.Role, "Demo")]
        [Route("api/v1/Employees/{id}")]
        [HttpGet]
        [ApiDocumentation("fc636230-e90b-406a-bd35-58a15b3bd873", "Get Employee by id.")]
        public async Task<ActionResult> Get(Guid id)
        {
            return await EmployeeQueries.Get(id);
        }

        [Authorize]
        [ClaimRequirement(ClaimTypes.Role, "Demo")]
        [Route("api/v1/Employees/paging")]
        [HttpGet]
        [ApiDocumentation("908730a0-89d5-4c0f-9c16-ffb3e4045568", "Get all employees by paging.")]
        public async Task<ActionResult> GetAll([FromQuery] PagingParams pagingParams)
        {
            return await EmployeeQueries.GetAll(pagingParams);
        }

        [Authorize]
        [ClaimRequirement(ClaimTypes.Role, "Demo")]
        [Route("api/v1/Employees")]
        [HttpPost]
        [ApiDocumentation("a19d0fe8-4bf9-4c0c-934d-37f9a8cbb4b6", "Create new employee.")]
        public async Task<ActionResult> Create([FromBody] CreateEmployeeModel request)
        {
            return await IEmployeeService.Create(request);
        }

        [Authorize]
        [ClaimRequirement(ClaimTypes.Role, "Demo")]
        [Route("api/v1/Employees/{id}")]
        [HttpPut]
        [ApiDocumentation("a19d0fe8-4bf9-4c0c-934d-37f9a8cbb4b6", "Update an employee by id.")]
        public async Task<ActionResult> Create(Guid id, [FromBody] UpdateEmployeeModel request)
        {
            return await IEmployeeService.Update(id,request);
        }

        [Authorize]
        [ClaimRequirement(ClaimTypes.Role, "Demo")]
        [Route("api/v1/Employees/{id}")]
        [HttpDelete]
        [ApiDocumentation("a19d0fe8-4bf9-4c0c-934d-37f9a8cbb4b6", "Delete an employee by id.")]
        public async Task<ActionResult> Delete(Guid id)
        {
            return await IEmployeeService.Delete(id);
        }
    }
}
