using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitcPPW.CQRS.AuthRole.GroupRoleCreate
{
    public class GroupRoleCreateRequestModel
    {
        public string RoleName { get; set; }
        public bool IsActive { get; set; }
        public List<RoleClaimList> ClaimLists { get; set; }
    }

    public class RoleClaimList
    {
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
    }
}
