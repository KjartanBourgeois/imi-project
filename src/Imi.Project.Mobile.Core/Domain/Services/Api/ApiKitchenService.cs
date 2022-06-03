using Imi.Project.Common.Dto;
using Imi.Project.Common.Services.Api;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Api
{
    public class ApiKitchenService : IKitchenService
    {
        private readonly string _baseUriPc;

        public ApiKitchenService()
        {
            _baseUriPc = Constants.Constants.BaseUriPc;
        }

        public async Task<IEnumerable<KitchenResponseDto>> GetAllKitchens()
        {
            return await WebApiClient.GetApiResult<IEnumerable<KitchenResponseDto>>($"{_baseUriPc}/api/Kitchens");
        }
    }
}