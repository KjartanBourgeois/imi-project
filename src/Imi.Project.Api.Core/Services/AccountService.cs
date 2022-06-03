using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Dtos.Account;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AccountService(UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<LoginResult> Login(LoginUserRequestDto login)
        {
            var userByMail = await _userManager.FindByEmailAsync(login.Email);
            var result = await _signInManager.PasswordSignInAsync(userByMail.UserName, login.Password, isPersistent: false, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByEmailAsync(login.Email);
                var claims = await GetClaimsFromUser(user);
                var jwtToken = GetJwtToken(user, claims);

                var claimsIdentity = new ClaimsIdentity(claims, JwtBearerDefaults.AuthenticationScheme);

                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                await _httpContextAccessor.HttpContext.SignInAsync(claimsPrincipal);

                return new LoginResult { Succeeded = true, JwtToken = jwtToken };
            }
            else
            {
                return new LoginResult
                {
                    Succeeded = false,
                    ErrorMessages = new List<string> {
                        "Something went wrong, please try again"
                    },
                    JwtToken = null
                };
            }
        }

        private string GetJwtToken(User user, IList<Claim> claims)
        {
            var expirationDays = _configuration.GetValue<int>("JWTConfiguration:TokenExpirationDays");
            var siginingKey = Encoding.UTF8.GetBytes(_configuration.GetValue<string>("JWTConfiguration:SigningKey"));
            var token = new JwtSecurityToken
            (
                issuer: _configuration.GetValue<string>("JWTConfiguration:Issuer"),
                audience: _configuration.GetValue<string>("JWTConfiguration:Audience"),
                claims: claims,
                expires: DateTime.UtcNow.Add(TimeSpan.FromDays(expirationDays)),
                notBefore: DateTime.UtcNow,
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(siginingKey),
                SecurityAlgorithms.HmacSha256)
            );

            var serializedToken = new JwtSecurityTokenHandler().WriteToken(token); //serialize the token
            return serializedToken;
        }

        private async Task<IList<Claim>> GetClaimsFromUser(User user)
        {
            var claims = await _userManager.GetClaimsAsync(user);

            foreach (var role in await _userManager.GetRolesAsync(user))
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }

        public async Task<JwtSecurityToken> GenerateTokenAsync(User user)
        {
            var claims = new List<Claim>();
            var userClaims = await _userManager.GetClaimsAsync(user);
            claims.AddRange(userClaims);

            var roleClaims = await _userManager.GetRolesAsync(user);

            foreach (var roleClaim in roleClaims)
            {
                claims.Add(new Claim(ClaimTypes.Role, roleClaim));
            }

            var expirationDays = _configuration.GetValue<int>("JWTConfiguration:TokenExpirationDays");
            var siginingKey = Encoding.UTF8.GetBytes(_configuration.GetValue<string>("JWTConfiguration:SigningKey"));
            var jwtToken = new JwtSecurityToken(
                issuer: _configuration.GetValue<string>("JWTConfiguration:Issuer"),
                audience: _configuration.GetValue<string>("JWTConfiguration:Audience"),
                claims: claims,
                expires: DateTime.UtcNow.Add(TimeSpan.FromDays(expirationDays)),
                notBefore: DateTime.UtcNow,
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(siginingKey),
                SecurityAlgorithms.HmacSha256)
                );

            return jwtToken;
        }

        public async Task<IdentityResult> Register(RegisterUserRequestDto registration)
        {
            User newUser = new User
            {
                FirstName = registration.FirstName,
                LastName = registration.LastName,
                UserName = registration.UserName,
                Gender = registration.Gender,
                DoB = registration.DateOfBirth,
                Email = registration.Email,
            };

            IdentityResult identityResult = await _userManager.CreateAsync(newUser, registration.Password);
            if (!identityResult.Succeeded)
            {
                return null;
            }
            newUser = await _userManager.FindByEmailAsync(registration.Email);
            await _userManager.AddClaimAsync(newUser, new Claim("OnlyConfirmedUsers", "true"));

            return identityResult;
        }
    }
}