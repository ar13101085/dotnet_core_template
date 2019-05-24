using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace KitcPPW.CQRS.WorkOrder.WorkOrderUpdate
{
    public class WorkOrderUpdateCmd:IRequest<WorkOrderUpdateResponseModel>
    {
        public string UserId { get; set; }
        public WorkOrderUpdateRequestModel Model { get; set; }
    }
}
