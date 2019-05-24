using System.Security.Authentication;
using System.Threading.Tasks;
using KitcPPW.Controllers.Base;
using KitcPPW.CQRS.Auth.CreateUser;
using KitcPPW.CQRS.Auth.LoginUser;
using KitcPPW.KitcAttribute;
using KitcPPW.Models.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KitcPPW.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    public class AuthController : BaseController
    {
        private readonly IHttpContextAccessor _context;
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator, IHttpContextAccessor context)
        {
            _mediator = mediator;
            _context = context;
        }

        [AllowAnonymous]
        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserRequestModel model)
        {
            var cmd = new CreateUserCmd
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
                LoginName = model.LoginName,
                Password = model.Password,
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
            var res = await _mediator.Send(cmd);
            return Ok(res);
        }

        [Role(HReadableActionName = "User Auth Test", UniqueValue = "GET_Auth_Test")]
        [HttpGet("Test")]
        public IActionResult Tester()
        {
            return Ok(true);
        }


        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginUserCmdRequestModel model)
        {
            var cmd = new LoginUserCmd
            {
                RequestModel = model
            };
            var res = await _mediator.Send(cmd);

            if(res==null)
                throw new AuthenticationException("Invalid Credential.Username or password invalid.");

            var response = new DefaultPayloadModel<LoginUserCmdResponseModel>
            {
                Result = res,
                Status = true,
                Message = res != null ? "Successfully Login" : "Invalid Login."
            };
            return Ok(response);
        }
    }
}