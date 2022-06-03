using Imi.Project.Common.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services
{
    public interface IRecipeService
    {
        Task<RecipeResponseDto> AddRecipe(RecipeRequestDto recipe, string token);

        Task<RecipeResponseDto> DeleteRecipe(Guid recipeId, string token);

        Task<RecipeResponseDto> GetRecipe(Guid recipeId);

        Task<RecipeResponseDto> UpdateRecipe(RecipeRequestDto recipe, string token);

        Task<IEnumerable<RecipeResponseDto>> GetAllRecipes();
    }
}