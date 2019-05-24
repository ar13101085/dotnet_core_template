using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitcPPW.Models;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace KitcPPW.CQRS.WorkOrder.AddPhoto
{
    public class AddPhotoCmd:IRequest<AddPhotoResponse>
    {
        public int WorkOrderId { get; set; }
        public IFormFile File { get; set; }
        public string FileType { get; set; }
        public PhotoLabel PhotoLabel { get; set; }

        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
        public decimal Altitude { get; set; }
    }
}
