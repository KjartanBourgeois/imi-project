using Imi.Project.Common.Dto;
using Imi.Project.Common.Services.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services.Api
{
    public class LoginService
    {
        private string baseUrl = "https://localhost:5001/api/Accounts";

        public async Task<LoginUserResponseDto> Login(string email, string password)
        {
            var requestDto = new LoginUserRequestDto();
            requestDto.Email = email;
            requestDto.Password = password;
            return await WebApiClient
                .PostCallApi<LoginUserResponseDto, LoginUserRequestDto>($"{baseUrl}/Login", requestDto);
        }
    }
}