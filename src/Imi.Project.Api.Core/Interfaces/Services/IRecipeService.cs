using Imi.Project.Api.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IRecipeService
    {
        Task<IEnumerable<RecipeResponseDto>> ListAllAsync();
        Task<RecipeResponseDto> GetByIdAsync(Guid id);
        Task<RecipeIngredientsResponseDto> GetIngredientsByRecipeIdAsync(Guid id);
        Task<RecipeResponseDto> AddAsync(RecipeRequestDto recipeRequestDto);
        Task<RecipeResponseDto> UpdateAsync(RecipeRequestDto recipeRequestDto);
        Task DeleteAsync(Guid id);
    }
}
