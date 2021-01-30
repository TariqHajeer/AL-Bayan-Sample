using StoreakApiService.Core.Responses;
using System;
using AutoMapper;
using Storeak.Models.Identity.BusinessUseCases.AppDevice;
using System.Threading.Tasks;
using Storeak.Demo.Api.Application.BusinessUseCases.AppDevice;
using Storeak.Demo.Api.Infrastructure;
using Storeak.Demo.Api.Application;
using Storeak.Models.Demo.BusinessUseCases.Employee;
using Storeak.Demo.Api.Infrastructure.DataModel;

namespace Storeak.Identity.Demo.Application.BusinessUseCases.AppDevice
{
    public class EmployeeService : IEmployeeService
    {
        private IMapper _mapper;
        private ResponseMessages _responsMessages;
        private UnitOfWork _unitOfWork;
        
        public EmployeeService(IMapper mapper, UnitOfWork unitOfWork, IResponseMessages responsMessages)
        {
            _mapper = mapper;
            _responsMessages = responsMessages as ResponseMessages;
            _unitOfWork = unitOfWork;
        }

        public async Task<CustomResponse> Create(CreateEmployeeModel request)
        {
            EmployeeDto employee = _mapper.Map<EmployeeDto>(request);
            _unitOfWork.EmployeeRepository.Add(employee);
            await _unitOfWork.SaveChangesAsync();
            return new OkResponse(employee.Id);
        }

        public async Task<CustomResponse> Delete(Guid id)
        {
            EmployeeDto appDeviceDto = _unitOfWork.EmployeeRepository.Find(id);

            if (appDeviceDto == null)
            {
                return _responsMessages.EmployeeNotFound;
            }
            _unitOfWork.EmployeeRepository.Remove(appDeviceDto);
            await _unitOfWork.SaveChangesAsync();
            return _responsMessages.EmployeeUpdatedSuccessfully;
        }

        public async Task<CustomResponse> Update(Guid id, UpdateEmployeeModel UpdateRequest)
        {
            EmployeeDto appDeviceDto = _unitOfWork.EmployeeRepository.Find(id);

            if (appDeviceDto == null)
            {
                return _responsMessages.EmployeeNotFound;
            }

            appDeviceDto.Name = UpdateRequest.Name;
            appDeviceDto.FatherName = UpdateRequest.FatherName;
            appDeviceDto.Age = UpdateRequest.Age;
            appDeviceDto.Type = UpdateRequest.Type;
            await _unitOfWork.SaveChangesAsync();
            return _responsMessages.EmployeeUpdatedSuccessfully;
        }
    }
}
