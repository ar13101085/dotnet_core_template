using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace KitcPPW.CQRS.FileManager.CreateFile
{
    public class CreateFileCmd:IRequest<Models.FileManager>
    {
        public IFormFile File { get; set; }
        public string FileType { get; set; }
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
        public decimal Altitude { get; set; }
        public string ExtraPath { get; set; }
    }
}
