using Imi.Project.Common.Dto;
using Imi.Project.Common.Services.Api;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Api
{
    public class ApiAccountService : IAccountService
    {
        private readonly string _baseUriPc;

        public ApiAccountService()
        {
            _baseUriPc = Constants.Constants.BaseUriPc;
        }

        public async Task<LoginUserResponseDto> Login(string login, string password)
        {
            var requestDto = new LoginUserRequestDto();
            requestDto.Email = login;
            requestDto.Password = password;
            return await WebApiClient
                .PostCallApi<LoginUserResponseDto, LoginUserRequestDto>($"{_baseUriPc}/api/Accounts/Login", requestDto);
        }
    }
}