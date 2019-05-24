using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitcPPW.Models
{
    public class Completion
    {
        public long CompletionId { get; set; }
        public int WorkOrderId { get; set; }
        public WorkOrder WorkOrder { get; set; }
        public int Quantity { get; set; }
        public string Comments { get; set; }
    }
}
