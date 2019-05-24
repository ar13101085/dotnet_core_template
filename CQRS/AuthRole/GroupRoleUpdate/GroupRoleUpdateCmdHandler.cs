using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using KitcPPW.CQRS.AuthRole.GroupRoleCreate;
using KitcPPW.Models;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace KitcPPW.CQRS.AuthRole.GroupRoleUpdate
{
    public class GroupRoleUpdateCmdHandler:IRequestHandler<GroupRoleUpdateCmd,bool>
    {
        private IMediator _mediator;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManger;

        public GroupRoleUpdateCmdHandler(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManger, IMediator mediator)
        {
            this._userManager = userManager;
            this._roleManger = roleManger;
            this._mediator = mediator;
        }

        public async Task<bool> Handle(GroupRoleUpdateCmd request, CancellationToken cancellationToken)
        {
            ApplicationRole role = _roleManger.Roles.FirstOrDefault(x => x.Id == request.RequestModel.RoleId);
            if (role == null)
            {
                return false;
            }

            var claims = await _roleManger.GetClaimsAsync(role);
            foreach (var claim in claims)
            {
                await _roleManger.RemoveClaimAsync(role, claim);
            }

            foreach (var item in request.RequestModel.ClaimLists)
            {
                var claim=new Claim(item.ClaimType,item.ClaimValue);
                await _roleManger.AddClaimAsync(role, claim);
            }

            role.IsActive = request.RequestModel.IsActive;
            role.Name = request.RequestModel.RoleName;
            await _roleManger.UpdateAsync(role);

            return true;
        }
    }
}
