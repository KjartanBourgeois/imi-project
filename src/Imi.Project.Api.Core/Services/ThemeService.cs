using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Helpers.Mappers;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class ThemeService : IThemeService
    {
        private readonly IThemeRepository _themeRepository;

        public ThemeService(IThemeRepository themeRepository)
        {
            _themeRepository = themeRepository;
        }

        public async Task<IEnumerable<ThemeResponseDto>> ListAllAsync()
        {
            var result = await _themeRepository.GetAllAsync().ToListAsync();
            var dto = result.MapToDto();

            return dto;
        }
        public async Task<ThemeResponseDto> GetByIdAsync(Guid id)
        {
            var theme = await _themeRepository.GetAllAsync().SingleOrDefaultAsync(x => x.Id.Equals(id));
            if (theme == null)
            {
                return null;
            }
            var dto = theme.MapToDto();

            return dto;
        }

        public async Task<ThemeResponseDto> AddAsync(ThemeRequestDto themeRequestDto)
        {
            var theme = new Theme { Id = themeRequestDto.Id, Name = themeRequestDto.Name };

            var result = await _themeRepository.AddAsync(theme);
            var dto = theme.MapToDto();
            return dto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _themeRepository.DeleteAsync(id);
        }

        public async Task<ThemeResponseDto> UpdateAsync(ThemeRequestDto themeRequestDto)
        {
            var theme = new Theme { Id = themeRequestDto.Id, Name = themeRequestDto.Name };
            var result = await _themeRepository.UpdateAsync(theme);
            var dto = result.MapToDto();
            return dto;
        }


        public async Task<ThemeRecipeResponseDto> GetRecipeByRecipeIdAsync(Guid id)
        {
            var theme = await _themeRepository.GetByIdAsync(id);

            if (theme == null)
            {
                return null;
            }
            var themeDto = theme.MapToThemeRecipeDto();

            return themeDto;
        }
    }
}
