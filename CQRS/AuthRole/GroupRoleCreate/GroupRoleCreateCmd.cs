using KitcPPW.CQRS.AuthRole.GroupRoleCreate;
using MediatR;

namespace KitcPPW.CQRS.AuthRole.GroupRoleCreate
{
    public class GroupRoleCreateCmd : IRequest<bool>
    {
        public GroupRoleCreateRequestModel RoleInfo { get; set; }
    }
}
