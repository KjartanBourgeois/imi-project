using Imi.Project.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services
{
    public interface IKitchenService
    {
        Task<KitchenResponseDto> AddKitchen(KitchenRequestDto kitchen, string token);

        Task<KitchenResponseDto> DeleteKitchen(Guid themeId, string token);

        Task<KitchenResponseDto> GetKitchen(Guid themeId);

        Task<KitchenResponseDto> UpdateKitchen(KitchenRequestDto kitchen, string token);

        Task<IEnumerable<KitchenResponseDto>> GetAllKitchens();
    }
}