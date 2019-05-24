using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using KitcPPW.Models;
using KitcPPW.Models.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace KitcPPW.CQRS.Auth.CreateUser
{
    public class CreateUserCmdHandler : IRequestHandler<CreateUserCmd, DefaultPayloadModel<object>>
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public CreateUserCmdHandler(IMediator mediator, UserManager<ApplicationUser> userManager)
        {
            _mediator = mediator;
            _userManager = userManager;
        }

        private IMediator _mediator { get; }

        public async Task<DefaultPayloadModel<object>> Handle(CreateUserCmd model, CancellationToken cancellationToken)
        {
            var appUser = new ApplicationUser
            {
                AbcHash = model.AbcHash,
                Address = model.Address,
                CellPhoneCompany = model.CellPhoneCompany,
                CellPhoneNumber = model.CellPhoneNumber,
                City = model.City,
                
                Comments = model.Comments,
                CompanyName = model.CompanyName,
                ContractorScore = model.ContractorScore,
                DevicemagicDeviceID = model.DevicemagicDeviceID,
                DiscountPercentage = model.DiscountPercentage,
                Email = model.Email,
                FirstName = model.FirstName,
                InsuranceExpire = model.InsuranceExpire,
                IsActive = model.IsActive,
                IsDisplayAllWorkOrders = model.IsDisplayAllWorkOrders,
                IsEmailFollowUp = model.IsEmailFollowUp,
                IsEmailNewsWoS = model.IsEmailNewsWoS,
                IsEmailNotes = model.IsEmailNotes,
                IsEmailRemainders = model.IsEmailRemainders,
                IsEmailReplyToJobNotes = model.IsEmailReplyToJobNotes,
                IsEmailUnAssigndWoS = model.IsEmailUnAssigndWoS,
                IsReadyForOffice = model.IsReadyForOffice,
                IsShowInListAssignedAdmin = model.IsShowInListAssignedAdmin,
                IsShowInListContractor = model.IsShowInListContractor,
                IsSkipOnAutoAssign = model.IsSkipOnAutoAssign,
                IsTextFollowUp = model.IsTextFollowUp,
                IsTextNewsWoS = model.IsTextNewsWoS,
                IsTextNotes = model.IsTextNotes,
                IsTextRemainders = model.IsTextRemainders,
                IsTextUnAssigndWoS = model.IsTextUnAssigndWoS,
                IsViewAllWoHistory = model.IsViewAllWoHistory,
                LastName = model.LastName,
                LegalFirstName = model.LegalFirstName,
                LegalLastName = model.LegalLastName,
                UserName = model.LoginName,
                PruvanDateOffset = model.PruvanDateOffset,
                PruvanPushKey = model.PruvanPushKey,
                PruvanUserName = model.PruvanUserName,
                SentAlertMinutes = model.SentAlertMinutes,
                ServiceLinkId = model.ServiceLinkId,
                StateListModelId = model.StateListModelId,
                SystemOfRecordId = model.SystemOfRecordId,
                TimeZoneListModelId = model.TimeZoneListModelId,
                Zip = model.Zip,
                AssignGroupRoleId = model.AssignGroupRoleId
            };

            var result = await _userManager.CreateAsync(appUser, model.Password);
            if (result.Succeeded)
            {
                Claim claim = new Claim("Auth_Test", "GET_Auth_Test");
                await _userManager.AddClaimAsync(appUser, claim);

                var data = new DefaultPayloadModel<object>
                {
                    Result = true,
                    Message = "Successfully Create User",
                    Status = true
                };
                return data;
            }

            


            var response = new DefaultPayloadModel<object>
            {
                Result = result.Errors,
                Message = "Successfully Create User",
                Status = false
            };
            return response;
        }
    }
}