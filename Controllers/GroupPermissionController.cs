using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using KitcPPW.Controllers.Base;
using KitcPPW.CQRS.Auth.RoleAssign;
using KitcPPW.CQRS.AuthRole.GetRoleList;
using KitcPPW.CQRS.AuthRole.GroupRoleCreate;
using KitcPPW.CQRS.AuthRole.GroupRoleUpdate;
using KitcPPW.CQRS.AuthRole.RoleAssign;
using KitcPPW.KitcAttribute;
using KitcPPW.Models.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KitcPPW.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    public class GroupPermissionController : BaseController
    {
        private readonly IHttpContextAccessor _context;
        private readonly IMediator _mediator;

        public GroupPermissionController(IMediator mediator, IHttpContextAccessor context)
        {
            _mediator = mediator;
            _context = context;
        }


        [HttpPost("GetAllResourceNameForRole")]
        public dynamic GetAllResourceNameForRole()
        {
            var list = new List<RoleAttribute>();
            foreach (var type in Assembly.Load("KitcPPW").GetTypes())
            {
                var listAttribute =
                    type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
                if (!type.IsSubclassOf(typeof(Controller)))
                    continue;
                foreach (var method in listAttribute)
                {
                    Debug.WriteLine(method);
                    var allMethodAttr = type.GetMethod(method.Name).GetCustomAttributes(typeof(RoleAttribute), true);

                    foreach (var attr in allMethodAttr)
                        if (attr is RoleAttribute)
                        {
                            var roleAttr = (RoleAttribute) attr;
                            //Debug.WriteLine(roleAttr.UniqueValue);
                            list.Add(roleAttr);
                        }
                }
            }

            return list.Select(x => new
            {
                Name = x.HReadableActionName,
                Value = x.UniqueValue
            }).ToList();
        }

        [HttpPost("RoleCreate")]
        public async Task<IActionResult> RoleCreateAsync([FromBody] GroupRoleCreateRequestModel model)
        {
            var cmd = new GroupRoleCreateCmd
            {
                RoleInfo = model
            };
            var res = await _mediator.Send(cmd);
            var response = new DefaultPayloadModel<bool>
            {
                Result = res,
                Status = res,
                Message = res ? "Successfully Create" : "Could Not Create."
            };
            return Ok(response);
        }


        [HttpPost("RoleUpdate")]
        public async Task<IActionResult> RoleUpdate([FromBody] GroupRoleUpdateRequestModel model)
        {
            var cmd = new GroupRoleUpdateCmd
            {
                RequestModel = model
            };
            var res = await _mediator.Send(cmd);
            var response = new DefaultPayloadModel<bool>
            {
                Result = res,
                Status = res,
                Message = res ? "Successfully Update" : "Could Not Update."
            };
            return Ok(response);
        }

        [Role(HReadableActionName = "User Get Role List", UniqueValue = "GET_Auth_GetRoleList")]
        [HttpGet("GetRoleList/{isShowDeletedItem}")]
        public async Task<IActionResult> GetRoleList(bool isShowDeletedItem)
        {
            var cmd = new GetRoleListCmd
            {
                IsShowDeletedRole = isShowDeletedItem
            };
            var res = await _mediator.Send(cmd);
            var response = new DefaultPayloadModel<List<GetRoleListResponseModel>>
            {
                Result = res,
                Status = true,
                Message = "Successfully get role list."
            };
            return Ok(response);
        }

        [Role(HReadableActionName = "Add Role Permission", UniqueValue = "GET_Auth_AddRole")]
        [HttpPost("AddRole")]
        public async Task<IActionResult> AddRole([FromBody] RoleAssignRequestModel model)
        {
            var cmd = new RoleAssignCmd
            {
                RequestModel = model
            };
            var res = await _mediator.Send(cmd);
            var response = new DefaultPayloadModel<bool>
            {
                Result = res.Result,
                Status = res.Result,
                Message = res.Message
            };
            return Ok(response);
        }
    }
}