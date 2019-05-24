using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitcPPW.Models
{
    public class FileManager
    {
        public long FileManagerId { get; set; }
        public string OriginalFileName { get; set; }
        public long FileSizeInKb { get; set; }
        public string FileType { get; set; }
        public decimal Lat { get; set; }
        public decimal Lng { get; set; }
        public decimal Altitude { get; set; }
        public string FileName { get; set; }

        public DateTime CreatedDateTime { get; set; }
    }
}
