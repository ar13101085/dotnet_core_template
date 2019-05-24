using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitcPPW.Controllers.Base;
using KitcPPW.CQRS.WorkOrder.GetWorkOrder;
using KitcPPW.CQRS.WorkOrder.GetWorkOrderList;
using KitcPPW.CQRS.WorkOrder.TakeWorkOrder;
using KitcPPW.CQRS.WorkOrder.WorkOrderUpdate;
using KitcPPW.Models;
using KitcPPW.Models.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KitcPPW.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    public class WorkOrderController:BaseController
    {
        private readonly IHttpContextAccessor _context;
        private readonly IMediator _mediator;
        private readonly UserManager<ApplicationUser> _userManager;


        public WorkOrderController(IMediator mediator, IHttpContextAccessor context, UserManager<ApplicationUser> userManager)
        {
            _mediator = mediator;
            _context = context;
            this._userManager = userManager;
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        [HttpPost("AddWorkOrder")]
        public async Task<IActionResult> AddWorkOrder([FromBody] TakeWorkOrderRequestModel model)
        {
            var loginUser = await GetCurrentUserAsync();

            var takeOrderCmd=new TakeWorkOrderCmd()
            {
                CreatedUserId = loginUser.Id,
                RequestModel = model
            };
            var res = new DefaultPayloadModel<TakeWorkOrderResponseModel>()
            {
                Message = "Successfully Created Order",
                Result = await _mediator.Send(takeOrderCmd),
                Status = true
            };
            return Ok(res);
        }


        [HttpPost("UpdateWorkOrder")]
        public async Task<IActionResult> UpdateWorkOrder([FromBody] WorkOrderUpdateRequestModel model)
        {
            var loginUser = await GetCurrentUserAsync();

            var takeOrderCmd = new WorkOrderUpdateCmd()
            {
                UserId = loginUser.Id,
                Model = model
            };
            var res = new DefaultPayloadModel<WorkOrderUpdateResponseModel>()
            {
                Message = "Successfully Created Order",
                Result = await _mediator.Send(takeOrderCmd),
                Status = true
            };
            return Ok(res);
        }
        [HttpGet("GetWorkOrder/{id}")]
        public async Task<IActionResult> GetWorkOrder(int id)
        {
            var getOrderCmd = new GetWorkOrderCmd()
            {
               WorkOrderId = id
            };
            var res = new DefaultPayloadModel<DefaultConvertModel<WorkOrder>>()
            {
                Message = "Successfully Get Order",
                Result = await _mediator.Send(getOrderCmd),
                Status = true
            };
            return Ok(res);
        }


        [HttpPost("GetWorkOrderListByFilter")]
        public async Task<IActionResult> GetWorkOrderListByFilter([FromBody]List<FilterItem> FilterList)
        {
            var workListOrderCmd = new GetWorkOrderListByFilterCmd()
            {
                FilterList = FilterList
            };
            var res = new DefaultPayloadModel<List<DefaultConvertModel<Models.WorkOrder>>>()
            {
                Message = "Successfully Get Order",
                Result = await _mediator.Send(workListOrderCmd),
                Status = true
            };
            return Ok(res);
        }


    }
}
