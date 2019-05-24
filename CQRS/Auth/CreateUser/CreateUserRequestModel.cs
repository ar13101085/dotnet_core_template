using System;

namespace KitcPPW.CQRS.Auth.CreateUser
{
    public class CreateUserRequestModel
    {
        #region User Basic Info

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public int SystemOfRecordId { get; set; }

        public string LoginName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string AssignGroupRoleId { get; set; }

        public bool IsShowInListContractor { get; set; }
        public bool IsShowInListAssignedAdmin { get; set; }

        public bool? IsActive { get; set; }
        public bool? IsDisplayAllWorkOrders { get; set; }
        public bool? IsViewAllWoHistory { get; set; }

        public bool DiscountPercentage { get; set; }

        public int TimeZoneListModelId { get; set; }

        public bool IsSkipOnAutoAssign { get; set; }

        #endregion

        #region End User's Legal Name

        public string LegalFirstName { get; set; }
        public string LegalLastName { get; set; }

        public string CellPhoneNumber { get; set; }
        public string CellPhoneCompany { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int StateListModelId { get; set; }
        public int Zip { get; set; }
        public string Comments { get; set; }

        #endregion

        #region Message/Aleart Options

        #region Email Options

        public bool IsEmailNotes { get; set; }
        public bool IsEmailRemainders { get; set; }
        public bool IsEmailNewsWoS { get; set; }
        public bool IsEmailUnAssigndWoS { get; set; }
        public bool IsEmailFollowUp { get; set; }

        #endregion


        #region Text Options

        public bool IsTextNotes { get; set; }
        public bool IsTextRemainders { get; set; }
        public bool IsTextNewsWoS { get; set; }
        public bool IsTextUnAssigndWoS { get; set; }
        public bool IsTextFollowUp { get; set; }

        #endregion


        #region Alert Options

        public bool IsEmailReplyToJobNotes { get; set; }
        public bool IsReadyForOffice { get; set; }
        public int SentAlertMinutes { get; set; }

        #endregion

        #endregion

        // public IList<SubContractCompany> SubContractCompanies { get; set; }

        #region Misc Setting

        public int ContractorScore { get; set; }
        public DateTime InsuranceExpire { get; set; }
        public string PruvanUserName { get; set; }
        public string PruvanPushKey { get; set; }

        public string PruvanDateOffset { get; set; }

        public string DevicemagicDeviceID { get; set; }
        public string AbcHash { get; set; }

        public string ServiceLinkId { get; set; }

        #endregion
    }
}