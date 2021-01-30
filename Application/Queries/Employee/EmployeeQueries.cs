using StoreakApiService.Core.Responses;
using AutoMapper;
using Storeak.Demo.Api.Infrastructure;
using Storeak.Demo.Api.Application;
using Storeak.Models.Demo.Queries.Employee;
using System;
using Storeak.Demo.Api.Infrastructure.DataModel;
using StoreakApiService.Core.Context;
using System.Linq;
using System.Threading.Tasks;

namespace Storeak.Demo.Api.Application.Queries.Employee
{
    public class EmployeeQueries
    {
        private IMapper _mapper;
        private ResponseMessages _responsMessages;
        private UnitOfWork _unitOfWork;
        
        public EmployeeQueries(IMapper mapper, UnitOfWork unitOfWork, IResponseMessages responsMessages)
        {
            _mapper = mapper;
            _responsMessages = responsMessages as ResponseMessages;
            _unitOfWork = unitOfWork;
        }

        public async Task<CustomResponse> Get(Guid id)
        {
            EmployeeDto employee = await _unitOfWork.EmployeeRepository.FindAsync(id);
            if (employee == null)
                return _responsMessages.EmployeeNotFound;

            GetEmployeeModel model = _mapper.Map<GetEmployeeModel>(employee);

            return new OkResponse(model);
        }

        public async Task<CustomResponse> GetAll(PagingParams pagingParams)
        {
            var result = await _unitOfWork.EmployeeRepository
                                    .GetAll()
                                    //.Where() // could create your own serch class by inherit from PagingParams to filter data based on your Params
                                    .GetPagedAsync<EmployeeDto,GetAllEmployeeModel>(pagingParams, _mapper);
            return new OkResponse(result);
        }
    }
}
