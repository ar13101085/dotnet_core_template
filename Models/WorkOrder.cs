using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;

namespace KitcPPW.Models
{
    public class WorkOrder
    {
        public int WorkOrderId { get; set; }
//        public int MasterPropertyId { get; set; }
//        public string WorkOrderNumber { get; set; } //WO #
//        public int CustomerNumber { get; set; }
//        public string WorkOrderType { get; set; }
//        public DateTime DateOrdered { get; set; }
//        public DateTime DateDue { get; set; }
//
//        
//        public string Property_Address { get; set; }
//        public string Property_City { get; set; }
//        public string Property_State { get; set; }
//        public string Property_ZipCode { get; set; }
//        public string AllocationArea { get; set; }
//        public string MCSStatus { get; set; }
//        public bool NeedCompletion { get; set; }
//        public bool NeedBid { get; set; }
//        public bool NeedInvoice { get; set; }
//        public bool NeedDamageReport { get; set; }
//        public bool StopWork { get; set; }
//        public string Comments { get; set; }
//        public ArrayList AdditionalInstructions { get; set; } //need to check
//        public IList<LineItem> LineItems { get; set; }
//
//        public ArrayList SubVendorNumber { get; set; } //need to check
//        public bool RequireVICCRChecklist { get; set; }
//
//        public DateTime LastGrassCutDate { get; set; }
//        public bool RequireUtilities { get; set; }
//
//        public int MaintainedArea { get; set; }
//        public int LawnSize { get; set; }
//        public bool HasExceptionFee { get; set; }
//
//        public ArrayList CutGrassDateRange { get; set; } //need to check

        //newly identified field

        public string WorkOrderNumber { get; set; } //WO #


        public int PPW { get; set; }

        public int CustomerListModelId { get; set; }
        public CustomerListModel CustomerListModel { get; set; }


        public int WorkTypeListModelId { get; set; }
        public WorkTypeListModel WorkTypeListModel { get; set; }
        public int CategoryListModelId { get; set; }
        public CategoryListModel CategoryListModel { get; set; }

        public string Address { get; set; }
        public int LoanNumber { get; set; }
        public string LoanType { get; set; }
        public string City { get; set; }
        public int StateListModelId { get; set; }
        public StateListModel StateListModel { get; set; }

        public int ZipCode { get; set; }
        public string ContractorId { get; set; }
        public ApplicationUser Contractor { get; set; }

        public string AdminId { get; set; }
        public ApplicationUser Admin { get; set; }

        public bool IsReadyForField { get; set; }

        public int RushListModelId { get; set; }
        public RushListModel RushListModel { get; set; }


        public bool IsBATF { get; set; }

        public string LotSize { get; set; }
        public string LockCode { get; set; }
        public string Mortgager { get; set; }
        public string KeyCode { get; set; }

        public int BackgroundCheckinProviderListModelId { get; set; }
        public BackgroundCheckinProviderListModel BackgroundCheckinProviderListModel { get; set; }


        public string LockLocation { get; set; }
        public string GateCode { get; set; }

        public DateTime ReceivedDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ClientDueDate { get; set; }

        public DateTime CompleteDate { get; set; }

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

        //public int OrderStatusId { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public WorkOrderStatus WorkOrderStatus { get; set; }


        public IList<AccessHistory> AccessHistoryList { get; set; }
        public IList<LineItem> LineItemList { get; set; }

        #region Client Info Details

        public int CompanyListModelId { get; set; }
        public CompanyListModel CompanyListModel { get; set; }

        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public string ClientEmail { get; set; }

        #endregion

        #region Recurring details

        public bool IsRecurring { get; set; }
        public int RecursEvery { get; set; }

        public int? RecursTypeListModelId { get; set; }
        public RecursTypeListModel RecursTypeListModel { get; set; }
        public DateTime RecursCutOffDate { get; set; }

        #endregion

        #region Last Update State
        public string LastUpdateByUserId { get; set; }
        public ApplicationUser LastUpdateByUser { get; set; }
        public string CreatedUserId { get; set; }
        public ApplicationUser CreatedUser { get; set; }
        public DateTime LastUpdateTime { get; set; }
        #endregion
    }

//    public class LineItem
//    {
//        public int WODetailID { get; set; }
//        public int WOID { get; set; }
//        public int CodeID { get; set; }
//        public string Instructions { get; set; }
//        public string LastModUserID { get; set; }
//        public DateTime LastModDate { get; set; }
//        public int BidInfoID { get; set; }
//        public bool MustBid { get; set; }
//        public bool MustComplete { get; set; }
//    }
//
//    public class CompletionInformation
//    {
//        public int WOCompID { get; set; }
//        public int WOID { get; set; }
//        public DateTime CompletionDate { get; set; }
//        public DateTime ModifiedDate { get; set; }
//        public int LotConditionID { get; set; }
//        public int VndrICC { get; set; }
//        public bool MobileHome { get; set; }
//        public int KeyCode1 { get; set; }
//        public int KeyCode2 { get; set; }
//        public int DoorSecure1 { get; set; }
//        public int DoorSecure2 { get; set; }
//        public bool Occupied { get; set; }
//        public int OccupancyVerification { get; set; }
//        public bool NoAccess { get; set; }
//        public int NoAccessReason { get; set; }
//        public bool VacPersonals { get; set; }
//        public bool BidItemsNotOnWO { get; set; }
//        public bool Damages { get; set; }
//        public bool NeedsBid { get; set; }
//        public bool MarketReady { get; set; }
//
//        public ArrayList PropertyUnsecured { get; set; }//need to check
//        public bool bReleaseKeystone { get; set; }
//        public bool bAllLineItemsNA { get; set; }
//
//        public int TarpCondition { get; set; }
//        public bool AutoCreated { get; set; }
//        public bool AutoReleased { get; set; }
//        public bool LockChange { get; set; }
//        public bool CompletionNotNeeded { get; set; }
//        public ArrayList LawnArea { get; set; } //Need to check
//        public ArrayList LotSize { get; set; } //Need to check
//        public ArrayList HasPool { get; set; } //Need to check
//
//        public int HasSumpPump { get; set; }
//        public int SumpPumpCondition { get; set; }
//        public int SumpPumpUtilitiesTransferred { get; set; }
//        public int HasMold { get; set; }
//        public int NeedMoldSpecialist { get; set; }
//        public bool EnvironmentalHazardsPresent { get; set; }
//        public bool AutoInvoiceWhenPossible { get; set; }
//        public bool AutoSubmitBidsWhenPossible { get; set; }
//
//        public ArrayList MaintainedArea { get; set; } //need to check
//        public ArrayList CompleteRecutsForAllowable { get; set; } //need to check
//
//        public bool IsSingleFamilyHome { get; set; }
//
//        public int Units { get; set; }
//
//        public ArrayList InvalidGCLotCondition { get; set; } //need to check
//        public ArrayList VacantLot { get; set; } //need to check
//        public ArrayList ViolationExists { get; set; } //need to check
//        public ArrayList InteriorAccessGained { get; set; } //need to check
//    }
//
//
//    public class CompletionLineItem
//    {
//        public int WODetID { get; set; }
//        public int CodeID { get; set; }
//        public string LineItemComment { get; set; }
//        public bool ItemComplete { get; set; }
//        public bool ItemNotNeeded { get; set; }
//        public bool ItemNeedsBids { get; set; }
//        public bool ItemPending { get; set; }
//        public DateTime IDateCompleted { get; set; }
//        public DateTime DateIReleasedToCust { get; set; }
//        public int IReleaseUserID { get; set; }
//        public DateTime ISubmittedDate { get; set; }
//        public int ISubmittedUserID { get; set; }
//        public DateTime IReleasedDate { get; set; }
//        public int WOCompDetID { get; set; }
//        public bool Multiday { get; set; }
//        public bool IsReadOnly { get; set; }
//        public bool ItemBATF { get; set; }
//        public int Qty { get; set; }
//        public bool MustBid { get; set; }
//        public bool MustComplete { get; set; }
//        public int VendorLineItemId { get; set; }
//        public string MaintCodeDescription { get; set; }
//        public int BidQty { get; set; }
//        public int BidAmt { get; set; }
//        public int ApprovedQty { get; set; }
//        public int ApprovedAmt { get; set; }
//
//
//    }


    public enum WorkOrderStatus
    {
        Unassigned, // when work order is created or imported
        Assigned, //when contractor is selected
        Unread, // until contractor view
        InField, // after contractor view 
        ReadyOffice, // when contractor complete his work
        Invoiced, // when invoice ready and work order not complete
        Closed, //when work order closed
        FollowUp // when there is issue related to perform work, DB field 'missing info' true or 'needs reviewed asap' true
    }

    public class LineItem
    {
        public int LineItemId { get; set; }
        public int LineItemDescriptionListModelId { get; set; }
        public LineItemDescriptionListModel LineItemDescriptionListModel { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public string AdditionalInstruction { get; set; }
    }


    public class OrderStatus
    {
        public int OrderStatusId { get; set; }
        //public bool ReadyForOffice { get; set; }
        public DateTime EstimateCompleteDate { get; set; }
        //public int CategoryId { get; set; }
        //public CategoryListModel Category { get; set; }
        public bool OfficeLocked { get; set; }
        public bool FreezeProperty { get; set; }
    }


    public enum OrderAccessStatus
    {
        Imported,
        Viewed,
        Saved,
        InvoiceViewed,
        InvoiceSaved,
        NoteSaved,
        NoteEdited
    }

    public class OrderAccessHistory
    {
        public long OrderAccessHistoryId { get; set; }
        public OrderAccessStatus Status { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public DateTime DateTime { get; set; }
    }

    public class WorkOrderFieldChangeHistory
    {
        public long WorkOrderFieldChangeHistoryId { get; set; }
        public int WorkOrderId { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }

    public enum WorkOrderFieldName
    {
        WorkTypeListModel,
        CategoryListModel,
        Contractor,
        ReceivedDate,
        StartDate,
        DueDate,
        ClientDueDate,
        CompleteDate,
        CancelDate
    }


    public enum PhotoLabel
    {
        Unflagged,
        BidOrCompletion,
        Forms,
        JobNotes,
        Trash
    }


    public class WorkOrderPhoto
    {
        public long WorkOrderPhotoId { get; set; }
        public int WorkOrderId { get; set; }

        public long FileId { get; set; }
        public FileManager File { get; set; }
        public PhotoLabel Label { get; set; }

        public string GetExtraPath()
        {
            return "WorkOrder/"+WorkOrderId+"";
        }


    }
}