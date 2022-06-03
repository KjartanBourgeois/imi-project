using Imi.Project.Common.Dto;
using Imi.Project.Common.Services.Api;
using Imi.Project.Wpf.Core.Constants;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Wpf.Core.Services.Api
{
    public class ApiCategoryService : ICategoryService
    {
        public ApiCategoryService()
        {
        }

        public async Task<IEnumerable<CategoryResponseDto>> GetAllCategories()
        {
            return await WebApiClient.GetApiResult<IEnumerable<CategoryResponseDto>>($"{BaseUri.Url}/api/Categories");
        }
    }
}