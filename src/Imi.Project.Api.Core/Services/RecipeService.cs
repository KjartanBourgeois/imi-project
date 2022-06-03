using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Helpers.Mappers;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recipeRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IKitchenRepository _kitchenRepository;
        private readonly IThemeRepository _themeRepository;

        public RecipeService(IRecipeRepository recipeRepository, ICategoryRepository categoryRepository, IKitchenRepository kitchenRepository, IThemeRepository themeRepository)
        {
            _recipeRepository = recipeRepository;
            _categoryRepository = categoryRepository;
            _kitchenRepository = kitchenRepository;
            _themeRepository = themeRepository;
        }

        public async Task<IEnumerable<RecipeResponseDto>> ListAllAsync()
        {
            var result = await _recipeRepository.GetAllAsync().ToListAsync();

            var dto = result.MapToDto();

            return dto;
        }

        public async Task<RecipeResponseDto> GetByIdAsync(Guid id)
        {
            var recipe = await _recipeRepository.GetByIdAsync(id);

            if (recipe == null)
            {
                return null;
            }

            var dto = recipe.MapToDto();
            return dto;
        }

        public async Task<RecipeIngredientsResponseDto> GetIngredientsByRecipeIdAsync(Guid id)
        {
            var result = await _recipeRepository.GetIngredientsByRecipeIdAsync(id);

            if (result == null)
            {
                return null;
            }

            var recipeDto = result.MapToRecipeIngredientsDto();

            return recipeDto;
        }

        public async Task<RecipeResponseDto> AddAsync(RecipeRequestDto recipeRequestDto)
        {
            var category = await _categoryRepository.GetByIdAsync(recipeRequestDto.CategoryId);
            if (category == null)
            {
                return null;
            }
            var kitchen = await _kitchenRepository.GetByIdAsync(recipeRequestDto.KitchenId);
            if (kitchen == null)
            {
                return null;
            }

            var theme = await _themeRepository.GetByIdAsync(recipeRequestDto.ThemeId);
            if (theme == null)
            {
                return null;
            }
            var recipe = new Recipe
            {
                Id = Guid.NewGuid(),
                Name = recipeRequestDto.Name,
                CategoryId = recipeRequestDto.CategoryId,
                KitchenId = recipeRequestDto.KitchenId,
                ThemeId = recipeRequestDto.ThemeId,
                WebsiteLink = recipeRequestDto.WebsiteLink,
                Instructions = recipeRequestDto.Instructions,
                NumberOfPersons = recipeRequestDto.NumberOfPersons,
                Image = recipeRequestDto.Image,
                CreatedOn = DateTime.Now,
            };

            var result = await _recipeRepository.AddAsync(recipe);

            var resultCategory = await _categoryRepository.GetByIdAsync(result.CategoryId);
            if (resultCategory == null)
            {
                return null;
            }
            var resultKitchen = await _kitchenRepository.GetByIdAsync(result.KitchenId);
            if (resultKitchen == null)
            {
                return null;
            }

            var resultTheme = await _themeRepository.GetByIdAsync(result.ThemeId);
            if (resultTheme == null)
            {
                return null;
            }

            result.Category = resultCategory;
            result.Kitchen = resultKitchen;
            result.Theme = resultTheme;

            var dto = result.MapToDto();
            return dto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _recipeRepository.DeleteAsync(id);
        }

        public async Task<RecipeResponseDto> UpdateAsync(RecipeRequestDto recipeRequestDto)
        {
            var resultCategory = await _categoryRepository.GetByIdAsync(recipeRequestDto.CategoryId);
            if (resultCategory == null)
            {
                return null;
            }
            var resultKitchen = await _kitchenRepository.GetByIdAsync(recipeRequestDto.KitchenId);
            if (resultKitchen == null)
            {
                return null;
            }

            var resultTheme = await _themeRepository.GetByIdAsync(recipeRequestDto.ThemeId);
            if (resultTheme == null)
            {
                return null;
            }

            var recipe = new Recipe
            {
                Id = recipeRequestDto.Id,
                Name = recipeRequestDto.Name,
                CategoryId = recipeRequestDto.CategoryId,
                Category = resultCategory,
                KitchenId = recipeRequestDto.KitchenId,
                Kitchen = resultKitchen,
                ThemeId = recipeRequestDto.ThemeId,
                Theme = resultTheme,
                WebsiteLink = recipeRequestDto.WebsiteLink,
                Instructions = recipeRequestDto.Instructions,
                NumberOfPersons = recipeRequestDto.NumberOfPersons,
                Image = recipeRequestDto.Image,
                CreatedOn = DateTime.Now,
            };
            var result = await _recipeRepository.UpdateAsync(recipe);
            var dto = result.MapToDto();
            return dto;
        }
    }
}