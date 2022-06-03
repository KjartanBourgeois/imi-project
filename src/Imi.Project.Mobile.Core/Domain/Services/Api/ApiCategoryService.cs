using Imi.Project.Common.Dto;
using Imi.Project.Common.Services.Api;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Api
{
    public class ApiCategoryService : ICategoryService
    {
        private readonly string _baseUriPc;

        public ApiCategoryService()
        {
            _baseUriPc = Constants.Constants.BaseUriPc;
        }

        public async Task<IEnumerable<CategoryResponseDto>> GetAllCategories()
        {
            return await WebApiClient.GetApiResult<IEnumerable<CategoryResponseDto>>($"{_baseUriPc}/api/Categories");
        }
    }
}