using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KitcPPW.Data;
using KitcPPW.Models;
using KitcPPW.Models.ViewModel;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace KitcPPW.CQRS.WorkOrder.GetWorkOrderList
{
    public class GetWorkOrderListByFilterCmdHandler:IRequestHandler<GetWorkOrderListByFilterCmd, List<DefaultConvertModel<Models.WorkOrder>>>
    {
        private readonly ApplicationDbContext _context;
        public GetWorkOrderListByFilterCmdHandler(ApplicationDbContext context)
        {
            this._context = context;
        }
        public Task<List<DefaultConvertModel<Models.WorkOrder>>> Handle(GetWorkOrderListByFilterCmd request, CancellationToken cancellationToken)
        {
            var workOrderQuery = _context.WorkOrders.AsQueryable();
            foreach (var filterItem in request.FilterList)
            {
                filterItem.QueryText = filterItem.QueryText.ToLower();

                if (filterItem.QueryType == FilterType.Address)
                {
                    workOrderQuery = workOrderQuery.Where(x => x.Address.ToLower().Contains(filterItem.QueryText));
                }else if (filterItem.QueryType == FilterType.WorkOrder)
                {
                    workOrderQuery = workOrderQuery.Where(x => x.WorkOrderNumber.ToLower().Contains(filterItem.QueryText));
                }
                else if (filterItem.QueryType == FilterType.City)
                {
                    workOrderQuery = workOrderQuery.Where(x => x.City.ToLower().Contains(filterItem.QueryText));
                }
                else if (filterItem.QueryType == FilterType.DateDue)
                {
                    workOrderQuery = workOrderQuery.Where(x => x.DueDate.ToString("dd-MM-yyyy").Contains(filterItem.QueryText));
                }
                else if (filterItem.QueryType == FilterType.DateReceived)
                {
                    workOrderQuery = workOrderQuery.Where(x => x.ReceivedDate.ToString("dd-MM-yyyy").Contains(filterItem.QueryText));
                }
                else if (filterItem.QueryType == FilterType.Ppw)
                {
                    workOrderQuery = workOrderQuery.Where(x => (x.PPW+"").Contains(filterItem.QueryText));
                }
                else if (filterItem.QueryType == FilterType.State)
                {
                    workOrderQuery = workOrderQuery.Where(x => x.StateListModel.Value.ToLower().Contains(filterItem.QueryText));
                }
                else if (filterItem.QueryType == FilterType.WorkType)
                {
                    workOrderQuery = workOrderQuery.Where(x => x.WorkTypeListModel.Value.ToLower().Contains(filterItem.QueryText));
                }
                else if (filterItem.QueryType == FilterType.Contractor)
                {
                    workOrderQuery = workOrderQuery.Where(x => x.ContractorId.Contains(filterItem.QueryText));
                }
                else if (filterItem.QueryType == FilterType.Admin)
                {
                    workOrderQuery = workOrderQuery.Where(x => x.AdminId.Contains(filterItem.QueryText));
                }
            }

            var list = workOrderQuery
                .Include(a => a.WorkTypeListModel)
                .Include(b => b.CategoryListModel)
                .Include(b => b.StateListModel)
                .Include(b=>b.CustomerListModel)
                .Include(b => b.RushListModel)
                .Include(b => b.BackgroundCheckinProviderListModel)
                .Include(b => b.OrderStatus)
                //.Include(b => b.AccessHistoryList)
                //.Include(b => b.LineItemList)
                .Include(b => b.CompanyListModel)
                .Include(b => b.RecursTypeListModel)
                .Select(y => new DefaultConvertModel<Models.WorkOrder>()
            {
                Data = y,
                Relation = new
                {
                    Contractor = new
                    {
                        y.Contractor.FirstName, y.Contractor.LastName
                    },
                    Admin = new
                    {
                        y.Admin.FirstName, y.Admin.LastName
                    },
                    LineItemList = y.LineItemList.Select(l=>new
                    {
                        l.LineItemId,
                        l.LineItemDescriptionListModelId,
                        l.LineItemDescriptionListModel.Value,
                        l.Qty,
                        l.Price,
                        l.Total,
                        l.AdditionalInstruction
                    }).ToList()
                    
                }
            }).ToList();
            return Task.FromResult(list);
            //throw new NullReferenceException("");
        }
    }
}
