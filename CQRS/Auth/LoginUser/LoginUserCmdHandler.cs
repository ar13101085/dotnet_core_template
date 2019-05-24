using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KitcPPW.Models;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace KitcPPW.CQRS.Auth.LoginUser
{
    public class LoginUserCmdHandler : IRequestHandler<LoginUserCmd, LoginUserCmdResponseModel>
    {
        private readonly IConfiguration _configuration;
        private readonly RoleManager<ApplicationRole> _roleManger;
        public UserManager<ApplicationUser> _userManager;

        public LoginUserCmdHandler(UserManager<ApplicationUser> userManager, IConfiguration configuration,
            RoleManager<ApplicationRole> roleManger)
        {
            _userManager = userManager;
            _configuration = configuration;
            _roleManger = roleManger;
        }

        public async Task<LoginUserCmdResponseModel> Handle(LoginUserCmd request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByNameAsync(request.RequestModel.UserName);
            var b = await _userManager.CheckPasswordAsync(user, request.RequestModel.Password);

            if (user == null || !b) return null;


            //            var claims = new[]
            //            {
            //                /*new Claim(JwtRegisteredClaimNames.Sub, loginViewModel.Email),
            //                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())*/
            //                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
            //                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            //                new Claim(ClaimTypes.NameIdentifier, user.Id),
            //                
            //            };


            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id)
            };

            var userRoles = await _userManager.GetRolesAsync(user);

            foreach (var userRole in userRoles)
            {
                claims.Add(new Claim("role", userRole));

                var role = await _roleManger.FindByNameAsync(userRole);

                if (role == null) continue;

                var roleClaims = await _roleManger.GetClaimsAsync(role);

                foreach (var roleClaim in roleClaims) claims.Add(roleClaim);
            }


            var expireTime = DateTime.UtcNow.AddDays(60);
            var token = new JwtSecurityToken
            (
                _configuration["Issuer"],
                _configuration["Audience"],
                claims,
                expires: expireTime,
                notBefore: DateTime.UtcNow,
                signingCredentials: new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["SigningKey"])),
                    SecurityAlgorithms.HmacSha256)
            );

            var res = new LoginUserCmdResponseModel
            {
                UserId = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                ExpireTime = expireTime,
                Token = "Bearer " + new JwtSecurityTokenHandler().WriteToken(token),
                UserFirstName = user.FirstName,
                UserLastName = user.LastName
            };
            return res;
        }
    }
}