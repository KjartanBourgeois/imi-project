using Imi.Project.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services
{
    public interface IThemeService
    {
        Task<ThemeResponseDto> AddTheme(ThemeRequestDto theme, string token);

        Task<ThemeResponseDto> DeleteTheme(Guid themeId, string token);

        Task<ThemeResponseDto> GetTheme(Guid themeId);

        Task<ThemeResponseDto> UpdateTheme(ThemeRequestDto theme, string token);

        Task<IEnumerable<ThemeResponseDto>> GetAllThemes();
    }
}