using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace KitcPPW.CQRS.AuthRole.GroupRoleUpdate
{
    public class GroupRoleUpdateCmd:IRequest<bool>
    {
        public GroupRoleUpdateRequestModel RequestModel { get; set; }

    }
}
