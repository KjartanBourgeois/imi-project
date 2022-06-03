using Imi.Project.Common.Dto;
using Imi.Project.Common.Services.Api;
using Imi.Project.Core.Helpers.Mapper;
using Imi.Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services.Api
{
    public class RecipeCategoriesService : ICategoryService
    {
        private string baseUrl = "https://localhost:5001/api/Categories";

        public async Task<CategoryResponseDto> AddCategory(CategoryRequestDto category, string token)
        {
            var apiResult = await WebApiClient.PostCallApiJwt<CategoryResponseDto, CategoryRequestDto>(baseUrl, category, token);
            return apiResult;
        }

        public async Task<CategoryResponseDto> DeleteCategory(Guid categoryId, string token)
        {
            var apiResult = await WebApiClient.DeleteCallApi<CategoryResponseDto>($"{baseUrl}/{categoryId}", token);
            return apiResult;
        }

        public async Task<CategoryResponseDto> GetCategory(Guid categoryId)
        {
            var apiResult = await WebApiClient.GetApiResult<CategoryResponseDto>($"{baseUrl}/{categoryId}");
            return apiResult;
        }

        public async Task<CategoryResponseDto> UpdateCategory(CategoryRequestDto category, string token)
        {
            var apiResult = await WebApiClient.PutCallApiJwt<CategoryResponseDto, CategoryRequestDto>(baseUrl, category, token);
            return apiResult;
        }

        public async Task<IEnumerable<CategoryResponseDto>> GetAllCategories()
        {
            var apiResult = await WebApiClient.GetApiResult<IEnumerable<CategoryResponseDto>>(baseUrl);
            return apiResult;
        }
    }
}