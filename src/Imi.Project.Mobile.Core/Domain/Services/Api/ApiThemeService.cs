using Imi.Project.Common.Dto;
using Imi.Project.Common.Services.Api;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Api
{
    public class ApiThemeService : IThemeService
    {
        private readonly string _baseUriPc;

        public ApiThemeService()
        {
            _baseUriPc = Constants.Constants.BaseUriPc;
        }

        public async Task<IEnumerable<ThemeResponseDto>> GetAllThemes()
        {
            return await WebApiClient.GetApiResult<IEnumerable<ThemeResponseDto>>($"{_baseUriPc}/api/Themes");
        }
    }
}