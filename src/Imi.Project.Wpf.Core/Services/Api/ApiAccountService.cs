using Imi.Project.Common.Dto;
using Imi.Project.Common.Services.Api;
using Imi.Project.Wpf.Core.Constants;
using System.Threading.Tasks;

namespace Imi.Project.Wpf.Core.Services.Api
{
    public class ApiAccountService : IAccountService
    {
        public ApiAccountService()
        {
        }

        public async Task<LoginUserResponseDto> Login(string login, string password)
        {
            var requestDto = new LoginUserRequestDto();
            requestDto.Email = login;
            requestDto.Password = password;
            return await WebApiClient
                .PostCallApi<LoginUserResponseDto, LoginUserRequestDto>($"{BaseUri.Url}/api/Accounts/Login", requestDto);
        }
    }
}