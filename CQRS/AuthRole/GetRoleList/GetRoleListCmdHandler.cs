using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using KitcPPW.Models;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace KitcPPW.CQRS.AuthRole.GetRoleList
{
    public class GetRoleListCmdHandler : IRequestHandler<GetRoleListCmd, List<GetRoleListResponseModel>>
    {
        public RoleManager<ApplicationRole> _roleManager;

        public GetRoleListCmdHandler(RoleManager<ApplicationRole> roleManager)
        {
            this._roleManager = roleManager;
        }

        public Task<List<GetRoleListResponseModel>> Handle(GetRoleListCmd request, CancellationToken cancellationToken)
        {
            var list = _roleManager.Roles.Where(a=>a.IsActive || request.IsShowDeletedRole).Select(x => new GetRoleListResponseModel
            {
                RoleId = x.Id,
                RoleName = x.Name
            }).ToList();
            return Task.FromResult(list);
        }
    }
}