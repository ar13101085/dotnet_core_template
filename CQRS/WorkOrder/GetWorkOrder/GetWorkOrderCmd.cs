using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitcPPW.Models.ViewModel;
using MediatR;

namespace KitcPPW.CQRS.WorkOrder.GetWorkOrder
{
    public class GetWorkOrderCmd:IRequest<DefaultConvertModel<Models.WorkOrder>>
    {
        public int WorkOrderId { get; set; }
    }
}
