using StoreakApiService.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storeak.Demo.Api.Infrastructure
{
    public class ResponseMessages : IResponseMessages
    {
        IResponsesManager _responsesManager;

        public ResponseMessages(IResponsesManager responsesManager)
        {
            _responsesManager = responsesManager;
        }

        public CustomResponse EmployeeNotFound
        {
            get { return _responsesManager.GetResponce("EmployeeNotFound"); }
        }

        public CustomResponse EmployeeUpdatedSuccessfully
        {
            get { return _responsesManager.GetResponce("EmployeeUpdatedSuccessfully"); }
        }

        public CustomResponse EmployeeDeletedSuccessfully
        {
            get { return _responsesManager.GetResponce("EmployeeDeletedSuccessfully"); }
        }

        public CustomResponse GlobalInternalServerError()
        {
            return _responsesManager.GetResponce("InternalServerError");
        }
    }
}
