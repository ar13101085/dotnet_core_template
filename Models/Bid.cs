using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitcPPW.Models
{
    public class Bid
    {
        public long BidId { get; set; }
        public int WorkOrderId { get; set; }
        public WorkOrder WorkOrder { get; set; }
        public int Quantity { get; set; }
        public decimal ContractorPrice { get; set; }
        public decimal ClientPrice { get; set; }
        public string Comments { get; set; }
    }
}
