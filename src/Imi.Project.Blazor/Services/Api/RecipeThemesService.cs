using Imi.Project.Common.Dto;
using Imi.Project.Common.Services.Api;
using Imi.Project.Core.Helpers.Mapper;
using Imi.Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services.Api
{
    public class RecipeThemesService : IThemeService
    {
        private string baseUrl = "https://localhost:5001/api/Themes";

        public async Task<ThemeResponseDto> AddTheme(ThemeRequestDto theme, string token)
        {
            var apiResult = await WebApiClient.PostCallApiJwt<ThemeResponseDto, ThemeRequestDto>(baseUrl, theme, token);
            return apiResult;
        }

        public async Task<ThemeResponseDto> DeleteTheme(Guid themeId, string token)
        {
            var apiResult = await WebApiClient.DeleteCallApi<ThemeResponseDto>($"{baseUrl}/{themeId}", token);
            return apiResult;
        }

        public async Task<IEnumerable<ThemeResponseDto>> GetAllThemes()
        {
            var apiResult = await WebApiClient.GetApiResult<IEnumerable<ThemeResponseDto>>(baseUrl);
            return apiResult;
        }

        public async Task<ThemeResponseDto> GetTheme(Guid themeId)
        {
            var apiResult = await WebApiClient.GetApiResult<ThemeResponseDto>($"{baseUrl}/{themeId}");
            return apiResult;
        }

        public async Task<ThemeResponseDto> UpdateTheme(ThemeRequestDto theme, string token)
        {
            var apiResult = await WebApiClient.PutCallApiJwt<ThemeResponseDto, ThemeRequestDto>(baseUrl, theme, token);
            return apiResult;
        }
    }
}