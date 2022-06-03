using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Helpers.Mappers;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<CategoryResponseDto>> ListAllAsync()
        {
            var categories = await _categoryRepository.ListAllAsync();

            var dto = categories.MapToDto();

            return dto;
        }

        public async Task<CategoryResponseDto> GetByIdAsync(Guid id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);

            if (category == null)
            {
                return null;
            }
            var categoryDto = category.MapToDto();

            return categoryDto;
        }

        public async Task<CategoryRecipeResponseDto> GetRecipesByCateogryIdAsync(Guid id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);

            if (category == null)
            {
                return null;
            }
            var categoryDto = category.MapToCategoryRecipeDto();

            return categoryDto;
        }

        public async Task<CategoryResponseDto> UpdateAsync(CategoryRequestDto categoryRequestDto)
        {
            var category = new Category { Id = categoryRequestDto.Id, Name = categoryRequestDto.Name };
            var result = await _categoryRepository.UpdateAsync(category);
            var categoryDto = result.MapToDto();
            return categoryDto;
        }

        public async Task<CategoryResponseDto> AddAsync(CategoryRequestDto categoryRequestDto)
        {
            var category = new Category { Id = categoryRequestDto.Id, Name = categoryRequestDto.Name };

            var result = await _categoryRepository.AddAsync(category);
            var categoryDto = result.MapToDto();
            return categoryDto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _categoryRepository.DeleteAsync(id);
        }

    }
}
