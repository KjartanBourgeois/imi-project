using Imi.Project.Common.Dto;
using Imi.Project.Common.Services.Api;
using Imi.Project.Core.Helpers.Mapper;
using Imi.Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services.Api
{
    public class RecipeService : IRecipeService
    {
        private string baseUrl = "https://localhost:5001/api/Recipes";

        public async Task<RecipeResponseDto> AddRecipe(RecipeRequestDto recipe, string token)
        {
            var apiResult = await WebApiClient.PostCallApiJwt<RecipeResponseDto, RecipeRequestDto>(baseUrl, recipe, token);
            return apiResult;
        }

        public async Task<RecipeResponseDto> DeleteRecipe(Guid themeId, string token)
        {
            var apiResult = await WebApiClient.DeleteCallApi<RecipeResponseDto>($"{baseUrl}/{themeId}", token);
            return apiResult;
        }

        public async Task<IEnumerable<RecipeResponseDto>> GetAllRecipes()
        {
            var apiResult = await WebApiClient.GetApiResult<IEnumerable<RecipeResponseDto>>(baseUrl);
            return apiResult;
        }

        public async Task<RecipeResponseDto> GetRecipe(Guid themeId)
        {
            var apiResult = await WebApiClient.GetApiResult<RecipeResponseDto>($"{baseUrl}/{themeId}");
            return apiResult;
        }

        public async Task<RecipeResponseDto> UpdateRecipe(RecipeRequestDto recipe, string token)
        {
            var apiResult = await WebApiClient.PutCallApiJwt<RecipeResponseDto, RecipeRequestDto>(baseUrl, recipe, token);
            return apiResult;
        }
    }
}