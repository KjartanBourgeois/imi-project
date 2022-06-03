using Imi.Project.Api.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IKitchenService
    {
        Task<IEnumerable<KitchenResponseDto>> ListAllAsync();
        Task<KitchenResponseDto> GetByIdAsync(Guid id);
        Task<KitchenRecipeResponseDto> GetRecipeByKitchenIdAsync(Guid id);
        Task<KitchenResponseDto> AddAsync(KitchenRequestDto kitchenRequestDto);
        Task<KitchenResponseDto> UpdateAsync(KitchenRequestDto kitchenRequestDto);
        Task DeleteAsync(Guid id);
    }
}
