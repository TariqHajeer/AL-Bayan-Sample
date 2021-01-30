using StoreakApiService.Core.Responses;
using AutoMapper;
using Storeak.Demo.Api.Infrastructure;
using Storeak.Demo.Api.Application;
using Storeak.Models.Demo.Queries.Employee;
using System;
using Storeak.Demo.Api.Infrastructure.DataModel;
using StoreakApiService.Core.Context;
using System.Linq;

namespace Storeak.Identity.Api.Application.Queries.Application
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

        public CustomResponse Get(Guid id)
        {
            EmployeeDto employee = _unitOfWork.EmployeeRepository.Find(id);
            if (employee == null)
                return _responsMessages.EmployeeNotFound;

            GetEmployeeModel model = _mapper.Map<GetEmployeeModel>(employee);

            return new OkResponse(model);
        }

        public CustomResponse GetAll(PagingParams pagingParams)
        {
            var result = _unitOfWork.EmployeeRepository
                                    .GetAll()
                                    //.Where() // could create your own serch class by inherit from PagingParams to filter data based on your Params
                                    .GetPaged<EmployeeDto,GetAllEmployeeModel>(pagingParams, _mapper);
            return new OkResponse(result);
        }
    }
}
