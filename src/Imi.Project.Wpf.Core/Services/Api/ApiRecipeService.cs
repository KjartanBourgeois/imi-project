using Imi.Project.Common.Dto;
using Imi.Project.Common.Services.Api;
using Imi.Project.Wpf.Core.Constants;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Wpf.Core.Services.Api
{
    public class ApiRecipeService : IRecipeService
    {
        public ApiRecipeService()
        {
        }

        public async Task<IEnumerable<RecipeResponseDto>> GetAllRecipes()
        {
            return await WebApiClient.GetApiResult<IEnumerable<RecipeResponseDto>>($"{BaseUri.Url}/api/Recipes/");
        }

        public async Task<RecipeResponseDto> AddRecipe(RecipeRequestDto recipe, string token)
        {
            return await WebApiClient
                .PostCallApiJwt<RecipeResponseDto, RecipeRequestDto>($"{BaseUri.Url}/api/Recipes/", recipe, token);
        }

        public async Task<RecipeResponseDto> DeleteRecipe(Guid recipeId, string token)
        {
            return await WebApiClient
                .DeleteCallApi<RecipeResponseDto>($"{BaseUri.Url}/api/Recipes/{recipeId}", token);
        }

        public async Task<RecipeResponseDto> UpdateRecipe(RecipeRequestDto recipe, string token)
        {
            return await WebApiClient
                .PutCallApiJwt<RecipeResponseDto, RecipeRequestDto>($"{BaseUri.Url}/api/Recipes/", recipe, token);
        }
    }
}