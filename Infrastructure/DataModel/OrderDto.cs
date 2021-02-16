using StoreakApiService.Core.Context.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storeak.Demo.Api.Infrastructure.DataModel
{
    public class OrderDto: TrackableDto
    {
        public DateTime OrderDate { get; set; }

    }
}
