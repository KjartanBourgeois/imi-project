using Imi.Project.Api.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IIngredientService
    {
        Task<IEnumerable<IngredientResponseDto>> ListAllAsync();
        Task<IngredientResponseDto> GetByIdAsync(Guid id);
        Task<IngredientResponseDto> AddAsync(IngredientRequestDto ingredientsRequestDto);
        Task<IngredientResponseDto> UpdateAsync(IngredientRequestDto ingredientsRequestDto);
        Task DeleteAsync(Guid id);
    }
}
