using Imi.Project.Api.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IThemeService
    {
        Task<IEnumerable<ThemeResponseDto>> ListAllAsync();
        Task<ThemeResponseDto> GetByIdAsync(Guid id);
        Task<ThemeRecipeResponseDto> GetRecipeByRecipeIdAsync(Guid id);
        Task<ThemeResponseDto> AddAsync(ThemeRequestDto themeRequestDto);
        Task<ThemeResponseDto> UpdateAsync(ThemeRequestDto themeRequestDto);
        Task DeleteAsync(Guid id);

    }
}
