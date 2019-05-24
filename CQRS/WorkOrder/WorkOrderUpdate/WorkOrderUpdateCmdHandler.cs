using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KitcPPW.Data;
using KitcPPW.Filters.Exception;
using KitcPPW.Models;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace KitcPPW.CQRS.WorkOrder.WorkOrderUpdate
{
    public class WorkOrderUpdateCmdHandler : IRequestHandler<WorkOrderUpdateCmd, WorkOrderUpdateResponseModel>
    {
        public IConfiguration _configuration;
        public IMediator _mediator;
        public UserManager<ApplicationUser> _userManger;

        public WorkOrderUpdateCmdHandler(IMediator mediator, IConfiguration configuration,
            UserManager<ApplicationUser> userManger)
        {
            _mediator = mediator;
            _configuration = configuration;
            _userManger = userManger;
        }

        public async Task<WorkOrderUpdateResponseModel> Handle(WorkOrderUpdateCmd request,
            CancellationToken cancellationToken)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            var context = new ApplicationDbContext(optionsBuilder.Options);

            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    var workOrder = context.WorkOrders
                        .Include(a => a.WorkTypeListModel)
                        .Include(b => b.CategoryListModel)
                        .Include(b => b.StateListModel)
                        .Include(b=>b.Contractor)
                        .Include(b => b.RushListModel)
                        .Include(b => b.BackgroundCheckinProviderListModel)
                        .Include(b => b.OrderStatus)
                        .Include(b => b.AccessHistoryList)
                        .Include(b => b.LineItemList)
                        .Include(b => b.CompanyListModel)
                        .Include(b => b.RecursTypeListModel)
                        .FirstOrDefault(x => x.WorkOrderId == request.Model.WorkOrderId);

                    if (workOrder == null) throw new NotFoundException("WorkOrder", request.Model.WorkOrderId + "");

                    var model = request.Model;

                    #region Field History save

                    if (workOrder.WorkTypeListModelId != model.WorkTypeListModelId)
                    {
                        var workOrderFiledUpdate = new WorkOrderFieldChangeHistory
                        {
                            UserId = request.UserId,
                            ModifyDateTime = DateTime.Now,
                            OldValue = workOrder.WorkTypeListModel.Value,
                            WorkOrderId = workOrder.WorkOrderId,
                            FieldName = Enum.GetName(typeof(WorkOrderFieldName),
                                WorkOrderFieldName.WorkTypeListModel)
                        };
                        context.WorkOrderFieldChangeHistories.Add(workOrderFiledUpdate);
                        context.SaveChanges();
                    }

                    if (workOrder.CategoryListModelId != model.CategoryListModelId)
                    {
                        var categoryListModel =
                            context.CategoryListModel.FirstOrDefault(x =>
                                x.CategoryListModelId == workOrder.CategoryListModelId);
                        if (categoryListModel != null)
                        {
                            var workOrderFiledUpdate = new WorkOrderFieldChangeHistory
                            {
                                UserId = request.UserId,
                                ModifyDateTime = DateTime.Now,
                                OldValue = categoryListModel.Value,
                                WorkOrderId = workOrder.WorkOrderId,
                                FieldName = Enum.GetName(typeof(WorkOrderFieldName),
                                    WorkOrderFieldName.CategoryListModel)
                            };
                            context.WorkOrderFieldChangeHistories.Add(workOrderFiledUpdate);
                            context.SaveChanges();
                        }
                    }

                    if (workOrder.ContractorId != model.ContractorId)
                    {
                        var contractor = await _userManger.FindByIdAsync(workOrder.ContractorId);
                        if (contractor != null)
                        {
                            var workOrderFiledUpdate = new WorkOrderFieldChangeHistory
                            {
                                UserId = request.UserId,
                                ModifyDateTime = DateTime.Now,
                                //OldValue = co,
                                WorkOrderId = workOrder.WorkOrderId,
                                FieldName = Enum.GetName(typeof(WorkOrderFieldName),
                                    WorkOrderFieldName.Contractor)
                            };
                            context.WorkOrderFieldChangeHistories.Add(workOrderFiledUpdate);
                            context.SaveChanges();
                        }
                    }

                    if (workOrder.ReceivedDate != model.ReceivedDate)
                    {
                    }

                    if (workOrder.StartDate != model.StartDate)
                    {
                    }

                    if (workOrder.DueDate != model.DueDate)
                    {
                    }

                    if (workOrder.ClientDueDate != model.ClientDueDate)
                    {
                    }

                    if (workOrder.CompleteDate != model.CompleteDate)
                    {
                    }

                    if (workOrder.CancelDate != model.CancelDate)
                    {
                    }

                    #endregion


                    transaction.Commit();
                }
                catch (Exception e)
                {
                    throw new Exception(e.ToString());
                }
            }


            throw new NullReferenceException("");
        }
    }
}