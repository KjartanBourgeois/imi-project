using Imi.Project.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services
{
    public interface IRecipeService
    {
        Task<RecipeResponseDto> AddRecipe(RecipeRequestDto recipe, string token);

        Task<RecipeResponseDto> DeleteRecipe(Guid themeId, string token);

        Task<RecipeResponseDto> GetRecipe(Guid themeId);

        Task<RecipeResponseDto> UpdateRecipe(RecipeRequestDto recipe, string token);

        Task<IEnumerable<RecipeResponseDto>> GetAllRecipes();
    }
}