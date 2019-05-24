using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KitcPPW.Data;
using KitcPPW.Filters.Exception;
using KitcPPW.Models.ViewModel;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KitcPPW.CQRS.WorkOrder.GetWorkOrder
{
    public class GetWorkOrderHandler:IRequestHandler<GetWorkOrderCmd, DefaultConvertModel<Models.WorkOrder>>
    {
        private readonly ApplicationDbContext _context;
        public GetWorkOrderHandler(ApplicationDbContext context)
        {
            this._context = context;
        }
        public Task<DefaultConvertModel<Models.WorkOrder>> Handle(GetWorkOrderCmd request, CancellationToken cancellationToken)
        {
            var workOrder = _context.WorkOrders
                .Include(a=>a.WorkTypeListModel)
                .Include(b=>b.CategoryListModel)
                .Include(b=>b.StateListModel)
                //.Include(b=>b.Contractor)
                .Include(b=>b.RushListModel)
                .Include(b=>b.BackgroundCheckinProviderListModel)
                .Include(b=>b.OrderStatus)
                .Include(b=>b.AccessHistoryList)
                .Include(b=>b.LineItemList)
                .Include(b=>b.CompanyListModel)
                .Include(b=>b.RecursTypeListModel)
                .Where(x => x.WorkOrderId == request.WorkOrderId)
                .Select(y=>new DefaultConvertModel<Models.WorkOrder>()
                {
                    Data=y,
                    Relation= new
                    {
                        Contractor=new
                        {
                            FirstName=y.Contractor.FirstName,
                            LastName=y.Contractor.LastName
                        },
                        Admin = new
                        {
                            FirstName = y.Admin.FirstName,
                            LastName = y.Admin.LastName
                        }
                    }
                }).FirstOrDefault();
            if (workOrder == null)
            {
                throw new NotFoundException("workOrder", request.WorkOrderId+"");
            }

            return Task.FromResult(workOrder);
        }
    }
}
