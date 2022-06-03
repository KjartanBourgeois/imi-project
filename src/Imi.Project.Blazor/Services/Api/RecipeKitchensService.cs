using Imi.Project.Common.Dto;
using Imi.Project.Common.Services.Api;
using Imi.Project.Core.Helpers.Mapper;
using Imi.Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services.Api
{
    public class RecipeKitchensService : IKitchenService
    {
        private string baseUrl = "https://localhost:5001/api/Kitchens";

        public async Task<KitchenResponseDto> AddKitchen(KitchenRequestDto kitchen, string token)
        {
            var apiResult = await WebApiClient.PostCallApiJwt<KitchenResponseDto, KitchenRequestDto>(baseUrl, kitchen, token);
            return apiResult;
        }

        public async Task<KitchenResponseDto> DeleteKitchen(Guid kitchenId, string token)
        {
            var apiResult = await WebApiClient.DeleteCallApi<KitchenResponseDto>($"{baseUrl}/{kitchenId}", token);
            return apiResult;
        }

        public async Task<KitchenResponseDto> GetKitchen(Guid kitchenId)
        {
            var apiResult = await WebApiClient.GetApiResult<KitchenResponseDto>($"{baseUrl}/{kitchenId}");
            return apiResult;
        }

        public async Task<KitchenResponseDto> UpdateKitchen(KitchenRequestDto kitchen, string token)
        {
            var apiResult = await WebApiClient.PutCallApiJwt<KitchenResponseDto, KitchenRequestDto>(baseUrl, kitchen, token);
            return apiResult;
        }

        public async Task<IEnumerable<KitchenResponseDto>> GetAllKitchens()
        {
            var apiResult = await WebApiClient.GetApiResult<IEnumerable<KitchenResponseDto>>(baseUrl);
            return apiResult;
        }
    }
}