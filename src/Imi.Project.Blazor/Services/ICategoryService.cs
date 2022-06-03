using Imi.Project.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services
{
    public interface ICategoryService
    {
        Task<CategoryResponseDto> AddCategory(CategoryRequestDto category, string token);

        Task<CategoryResponseDto> DeleteCategory(Guid categoryId, string token);

        Task<CategoryResponseDto> GetCategory(Guid categoryId);

        Task<CategoryResponseDto> UpdateCategory(CategoryRequestDto category, string token);

        Task<IEnumerable<CategoryResponseDto>> GetAllCategories();
    }
}