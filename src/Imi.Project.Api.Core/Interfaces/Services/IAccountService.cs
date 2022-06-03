using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Dtos.Account;
using Imi.Project.Api.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IAccountService
    {
        Task<IdentityResult> Register(RegisterUserRequestDto registration);

        Task<LoginResult> Login(LoginUserRequestDto login);

        Task<JwtSecurityToken> GenerateTokenAsync(User user);
    }
}