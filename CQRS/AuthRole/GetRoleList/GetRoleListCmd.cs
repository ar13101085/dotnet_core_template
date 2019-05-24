using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace KitcPPW.CQRS.AuthRole.GetRoleList
{
    public class GetRoleListCmd:IRequest<List<GetRoleListResponseModel>>
    {
        public bool IsShowDeletedRole { get; set; }
    }
}
