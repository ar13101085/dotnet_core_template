using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitcPPW.Models;

namespace KitcPPW.CQRS.WorkOrder.TakeWorkOrder
{
    public class TakeWorkOrderRequestModel
    {
        public string WorkOrderNumber { get; set; }

        public int CustomerListModelId { get; set; }
        public int WorkTypeListModelId { get; set; }
        public int CategoryListModelId { get; set; }
        public string Address { get; set; }
        public int LoanNumber { get; set; }
        public string LoanType { get; set; }
        public string City { get; set; }
        public int StateListModelId { get; set; }

        public int PPW { get; set; }

        public int ZipCode { get; set; }
        public string ContractorId { get; set; }

        public string AdminId { get; set; }

        public bool IsReadyForField { get; set; }

        public int RushListModelId { get; set; }


        public bool IsBATF { get; set; }

        public string LotSize { get; set; }
        public string LockCode { get; set; }
        public string Mortgager { get; set; }
        public string KeyCode { get; set; }

        public int BackgroundCheckinProviderListModelId { get; set; }


        public string LockLocation { get; set; }
        public string GateCode { get; set; }

        public DateTime ReceivedDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ClientDueDate { get; set; }

        public string Comments { get; set; }


        public bool IsInspection { get; set; }

        public string BrokerName { get; set; }
        public string BrokerCompany { get; set; }
        public string BrokerPhone { get; set; }
        public string BrokerEmail { get; set; }

        //Complete Date from invoice date
        public DateTime CancelDate { get; set; }

        public bool IsMissingInfo { get; set; }
        public bool IsNeedsReviewedAsap { get; set; }
        public string MissingInfoComment { get; set; }


        public OrderStatus OrderStatus { get; set; }
        public IList<LineItem> LineItemList { get; set; }

        #region Client Info Details

        public int CompanyListModelId { get; set; }

        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public string ClientEmail { get; set; }

        #endregion

        #region Recurring details

        public bool IsRecurring { get; set; }
        public int RecursEvery { get; set; }

        public int RecursTypeListModelId { get; set; }
        public DateTime RecursCutOffDate { get; set; }

        #endregion
    }
}
