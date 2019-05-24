using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitcPPW.Models;

namespace KitcPPW.CQRS.WorkOrder.AddPhoto
{
    public class AddPhotoResponse
    {
        public long PhotoId { get; set; }
        public int WorkOrderId { get; set; }
        public long FileId { get; set; }
        public PhotoLabel Label { get; set; }
        public string Path { get; set; }
        public Models.FileManager FileInfo { get; set; }
    }
}
