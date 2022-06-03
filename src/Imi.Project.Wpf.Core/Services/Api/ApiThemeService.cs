using Imi.Project.Common.Dto;
using Imi.Project.Common.Services.Api;
using Imi.Project.Wpf.Core.Constants;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Wpf.Core.Services.Api
{
    public class ApiThemeService : IThemeService
    {
        public ApiThemeService()
        {
        }

        public async Task<IEnumerable<ThemeResponseDto>> GetAllThemes()
        {
            return await WebApiClient.GetApiResult<IEnumerable<ThemeResponseDto>>($"{BaseUri.Url}/api/Themes");
        }
    }
}