using MediatR;

namespace KitcPPW.CQRS.Auth.LoginUser
{
    public class LoginUserCmd : IRequest<LoginUserCmdResponseModel>
    {
        public LoginUserCmdRequestModel RequestModel { get; set; }
    }
}