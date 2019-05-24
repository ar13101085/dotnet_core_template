using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitcPPW.Models
{
    public class AccessHistory
    {
        public long AccessHistoryId { get; set; }
        public string Action { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
    }
}
