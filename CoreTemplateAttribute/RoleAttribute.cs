using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace KitcPPW.KitcAttribute
{
    public class RoleAttribute:Attribute
    {
        public string UniqueValue { get; set; }
        public string HReadableActionName { get; set; }
    }
}
