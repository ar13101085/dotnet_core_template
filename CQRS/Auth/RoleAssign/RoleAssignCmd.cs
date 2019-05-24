using KitcPPW.CQRS.Auth.RoleAssign;
using MediatR;

namespace KitcPPW.CQRS.AuthRole.RoleAssign
{
    public class RoleAssignCmd : IRequest<RoleAssignResponseModel>
    {
        public RoleAssignRequestModel RequestModel { get; set; }
    }
}