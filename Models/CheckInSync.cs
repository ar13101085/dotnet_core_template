using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitcPPW.Models
{
    public class CheckInSync
    {
        public int CheckInSyncId { get; set; }
        public string Client { get; set; }
        public DateTime Date { get; set; }
        public string Sent { get; set; }
        public string Status { get; set; }
    }
}
