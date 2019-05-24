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

namespace KitcPPW.CQRS.AuthRole.GroupRoleCreate
{
    public class GroupRoleCreateCmdHandler:IRequestHandler<GroupRoleCreateCmd,bool>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManger;

        public GroupRoleCreateCmdHandler(UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManger)
        {
            this._userManager = userManager;
            this._roleManger = roleManger;
        }

        public async Task<bool> Handle(GroupRoleCreateCmd request, CancellationToken cancellationToken)
        {
            var role = new ApplicationRole()
            {
                IsActive = request.RoleInfo.IsActive,
                Name = request.RoleInfo.RoleName
            };
            await _roleManger.CreateAsync(role);
            //var claim=new IdentityUserClaim<ApplicationUser>();
            foreach (var item in request.RoleInfo.ClaimLists)
            {
                var claim = new Claim(item.ClaimType, item.ClaimValue);
                await _roleManger.AddClaimAsync(role, claim);
            }
            //`_roleManger.
            return true;
        }
    }
}
