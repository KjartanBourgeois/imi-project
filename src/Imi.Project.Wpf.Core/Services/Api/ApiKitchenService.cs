using Imi.Project.Common.Dto;
using Imi.Project.Common.Services.Api;
using Imi.Project.Wpf.Core.Constants;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Wpf.Core.Services.Api
{
    public class ApiKitchenService : IKitchenService
    {
        public ApiKitchenService()
        {
        }

        public async Task<IEnumerable<KitchenResponseDto>> GetAllKitchens()
        {
            return await WebApiClient.GetApiResult<IEnumerable<KitchenResponseDto>>($"{BaseUri.Url}/api/Kitchens");
        }
    }
}