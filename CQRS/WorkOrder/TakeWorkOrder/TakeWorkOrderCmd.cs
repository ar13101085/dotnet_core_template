using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace KitcPPW.CQRS.WorkOrder.TakeWorkOrder
{
    public class TakeWorkOrderCmd:IRequest<TakeWorkOrderResponseModel>
    {
        public string CreatedUserId { get; set; }
        public TakeWorkOrderRequestModel RequestModel { get; set; }
    }
}
