using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitcPPW.CQRS.AuthRole.GroupRoleCreate;

namespace KitcPPW.CQRS.AuthRole.GroupRoleUpdate
{
    public class GroupRoleUpdateRequestModel
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public bool IsActive { get; set; }
        public List<RoleClaimList> ClaimLists { get; set; }
    }
}
