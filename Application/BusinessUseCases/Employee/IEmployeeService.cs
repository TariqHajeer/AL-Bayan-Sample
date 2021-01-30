using Storeak.Models.Demo.BusinessUseCases.Employee;
using StoreakApiService.Core.Responses;
using System;
using System.Threading.Tasks;

namespace Storeak.Demo.Api.Application.BusinessUseCases.AppDevice
{
    public interface IEmployeeService
    {
        Task<CustomResponse> Create(CreateEmployeeModel request);
        Task<CustomResponse> Update(Guid id, UpdateEmployeeModel request);
        Task<CustomResponse> Delete(Guid id);
    }
}
