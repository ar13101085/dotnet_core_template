using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KitcPPW.Data;
using KitcPPW.Models;
using MediatR;

namespace KitcPPW.CQRS.WorkOrder.TakeWorkOrder
{
    public class TakeWorkOrderCmdHandler:IRequestHandler<TakeWorkOrderCmd,TakeWorkOrderResponseModel>
    {
        public ApplicationDbContext _context;
        public TakeWorkOrderCmdHandler(ApplicationDbContext context)
        {
            this._context = context;
        }
        public Task<TakeWorkOrderResponseModel> Handle(TakeWorkOrderCmd request, CancellationToken cancellationToken)
        {
            var workOrder = new Models.WorkOrder()
            {
                CustomerListModelId = request.RequestModel.CustomerListModelId,
                Comments = request.RequestModel.Comments,
                Address = request.RequestModel.Address,
                City = request.RequestModel.City,
                StateListModelId = request.RequestModel.StateListModelId,
                AdminId = request.RequestModel.AdminId,
                BackgroundCheckinProviderListModelId = request.RequestModel.BackgroundCheckinProviderListModelId,
                BrokerCompany = request.RequestModel.BrokerCompany,
                BrokerEmail = request.RequestModel.BrokerEmail,
                BrokerName = request.RequestModel.BrokerName,
                BrokerPhone = request.RequestModel.BrokerPhone,
                CancelDate = request.RequestModel.CancelDate,
                CategoryListModelId = request.RequestModel.CategoryListModelId,
                ClientDueDate = request.RequestModel.ClientDueDate,
                ClientEmail = request.RequestModel.ClientEmail,
                ClientName = request.RequestModel.ClientName,
                ClientPhone = request.RequestModel.ClientPhone,
                CompanyListModelId = request.RequestModel.CompanyListModelId,
                ContractorId = request.RequestModel.ContractorId,
                StartDate = request.RequestModel.StartDate,
                DueDate = request.RequestModel.DueDate,
                GateCode = request.RequestModel.GateCode,
                IsBATF = request.RequestModel.IsBATF,
                IsInspection = request.RequestModel.IsInspection,
                IsMissingInfo = request.RequestModel.IsMissingInfo,
                IsNeedsReviewedAsap = request.RequestModel.IsNeedsReviewedAsap,
                IsReadyForField = request.RequestModel.IsReadyForField,
                IsRecurring = request.RequestModel.IsRecurring,
                KeyCode = request.RequestModel.KeyCode,
                LoanNumber = request.RequestModel.LoanNumber,
                LoanType = request.RequestModel.LoanType,
                LockCode = request.RequestModel.LockCode,
                LockLocation = request.RequestModel.LockLocation,
                LotSize = request.RequestModel.LotSize,

                MissingInfoComment = request.RequestModel.MissingInfoComment,
                Mortgager = request.RequestModel.Mortgager,
                OrderStatus = request.RequestModel.OrderStatus,
                PPW = request.RequestModel.PPW,
                ReceivedDate = request.RequestModel.ReceivedDate,
                RecursCutOffDate = request.RequestModel.RecursCutOffDate,
                RecursEvery = request.RequestModel.RecursEvery,
                RecursTypeListModelId = request.RequestModel.RecursTypeListModelId,
                RushListModelId = request.RequestModel.RushListModelId,
                WorkOrderNumber = request.RequestModel.WorkOrderNumber,
                WorkTypeListModelId = request.RequestModel.WorkTypeListModelId,
                ZipCode = request.RequestModel.ZipCode,
                //entity state update
                LastUpdateByUserId = request.CreatedUserId,
                CreatedUserId = request.CreatedUserId,
                LastUpdateTime = DateTime.Now,
                LineItemList = request.RequestModel.LineItemList,
                WorkOrderStatus = string.IsNullOrWhiteSpace(request.RequestModel.ContractorId)? WorkOrderStatus.Unassigned: WorkOrderStatus.Assigned

            };

            _context.WorkOrders.Add(workOrder);
            _context.SaveChanges();

            var res=new TakeWorkOrderResponseModel()
            {
                KitcPPWId = workOrder.WorkOrderId
            };
            return Task.FromResult(res);
        }
    }
}
