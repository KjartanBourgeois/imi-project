using Imi.Project.Common.Dto;
using Imi.Project.Common.Services.Api;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Api
{
    public class ApiRecipeService : IRecipeService
    {
        private readonly string _baseUriPc;

        public ApiRecipeService()
        {
            _baseUriPc = Constants.Constants.BaseUriPc;
        }

        public async Task<IEnumerable<RecipeResponseDto>> GetAllRecipes()
        {
            return await WebApiClient.GetApiResult<IEnumerable<RecipeResponseDto>>($"{_baseUriPc}/api/Recipes/");
        }

        public async Task<RecipeResponseDto> GetRecipe(Guid recipeId)
        {
            return await WebApiClient
                .GetApiResult<RecipeResponseDto>($"{_baseUriPc}/api/Recipes/{recipeId}");
        }

        public async Task<RecipeResponseDto> AddRecipe(RecipeRequestDto recipe, string token)
        {
            return await WebApiClient
                .PostCallApiJwt<RecipeResponseDto, RecipeRequestDto>($"{_baseUriPc}/api/Recipes/", recipe, token);
        }

        public async Task<RecipeResponseDto> DeleteRecipe(Guid recipeId, string token)
        {
            return await WebApiClient
                .DeleteCallApi<RecipeResponseDto>($"{_baseUriPc}/api/Recipes/{recipeId}", token);
        }

        public async Task<RecipeResponseDto> UpdateRecipe(RecipeRequestDto recipe, string token)
        {
            return await WebApiClient
                .PutCallApiJwt<RecipeResponseDto, RecipeRequestDto>($"{_baseUriPc}/api/Recipes/", recipe, token);
        }
    }
}