using System;

namespace KitcPPW.CQRS.Auth.LoginUser
{
    public class LoginUserCmdResponseModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string Token { get; set; }
        public DateTime ExpireTime { get; set; }
    }
}