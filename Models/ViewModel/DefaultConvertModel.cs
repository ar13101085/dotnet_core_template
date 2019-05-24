using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitcPPW.Models.ViewModel
{
    public class DefaultConvertModel<T>
    {
        public T Data { get; set; }
        public object Relation { get; set; }
    }
}
