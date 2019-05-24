using System.Collections.Generic;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using KitcPPW.Models;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace KitcPPW.CQRS.AuthRole.RoleAssign
{
    public class RoleAssignCmdHandler : IRequestHandler<RoleAssignCmd, RoleAssignResponseModel>
    {
        public RoleAssignCmdHandler(IMediator mediator, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            _mediator = mediator;
            _userManager = userManager;
            this._roleManager = roleManager;
        }

        public IMediator _mediator { get; set; }
        public UserManager<ApplicationUser> _userManager { get; set; }
        public RoleManager<ApplicationRole> _roleManager { get; set; }

        public async Task<RoleAssignResponseModel> Handle(RoleAssignCmd request, CancellationToken cancellationToken)
        {
            var applicationUser = await _userManager.FindByIdAsync(request.RequestModel.UserId);
            var role = await _roleManager.FindByIdAsync(request.RequestModel.RoleId);
            if (applicationUser != null && role!=null)
            {
//                var claimList = await _userManager.GetClaimsAsync(applicationUser);
//                await _userManager.RemoveClaimsAsync(applicationUser, claimList);
//
//                var list = new List<Claim>();
//                request.RoleList.ForEach(item =>
//                {
//                    var claim = new Claim(item.RoleType, item.RoleValue);
//                    list.Add(claim);
//                });
//                await _userManager.AddClaimsAsync(applicationUser, list);

                await _userManager.AddToRoleAsync(applicationUser, role.Name);

                var roleAssignResponseModel = new RoleAssignResponseModel
                {
                    Result = true,
                    Message = "Successfully role added."
                };
                return roleAssignResponseModel;
            }

            var res = new RoleAssignResponseModel
            {
                Message = "User Or Role Could not found.",
                Result = false
            };
            return res;
        }
    }
}