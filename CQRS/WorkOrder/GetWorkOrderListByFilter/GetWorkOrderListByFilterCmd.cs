using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitcPPW.Models.ViewModel;
using MediatR;

namespace KitcPPW.CQRS.WorkOrder.GetWorkOrderList
{
    public class GetWorkOrderListByFilterCmd : IRequest<List<DefaultConvertModel<Models.WorkOrder>>>
    {
        public List<FilterItem> FilterList { get; set; }
    }

    public class FilterItem
    {
        public string QueryText { get; set; }
        public FilterType QueryType { get; set; }
    }

    public enum FilterType
    {
        Address,
        City,
        State,
        DateDue,
        DateReceived,
        Ppw,
        WorkOrder,
        WorkType,
        Contractor,
        Admin
    }
}
