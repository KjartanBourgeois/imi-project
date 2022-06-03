using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Helpers.Mappers;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class KitchenService : IKitchenService
    {
        private readonly IKitchenRepository _kitchenRepository;

        public KitchenService(IKitchenRepository kitchenRepository)
        {
            _kitchenRepository = kitchenRepository;
        }

        public async Task<IEnumerable<KitchenResponseDto>> ListAllAsync()
        {
            var result = await _kitchenRepository.ListAllAsync();
            var dto = result.MapToDto();

            return dto;
        }
        public async Task<KitchenResponseDto> GetByIdAsync(Guid id)
        {
            var kitchen = await _kitchenRepository.GetByIdAsync(id);
            if (kitchen == null)
            {
                return null;
            }
            var dto = kitchen.MapToDto();


            return dto;
        }

        public async Task<KitchenResponseDto> AddAsync(KitchenRequestDto kitchenRequestDto)
        {
            var kitchen = new Kitchen { Id = kitchenRequestDto.Id, Name = kitchenRequestDto.Name };

            var result = await _kitchenRepository.AddAsync(kitchen);
            var dto = kitchen.MapToDto();

            return dto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _kitchenRepository.DeleteAsync(id);
        }

        public async Task<KitchenResponseDto> UpdateAsync(KitchenRequestDto kitchenRequestDto)
        {
            var kitchen = new Kitchen { Id = kitchenRequestDto.Id, Name = kitchenRequestDto.Name };
            var result = await _kitchenRepository.UpdateAsync(kitchen);
            var dto = kitchen.MapToDto();
            return dto;
        }

        public async Task<KitchenRecipeResponseDto> GetRecipeByKitchenIdAsync(Guid id)
        {
            var kitchen = await _kitchenRepository.GetByIdAsync(id);

            if (kitchen == null)
            {
                return null;
            }
            var kitchenDto = kitchen.MapToKitchenRecipeDto();

            return kitchenDto;
        }
    }
}
