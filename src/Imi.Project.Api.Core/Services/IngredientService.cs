using AutoMapper;
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
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientsRepository _ingredientRepository;

        public IngredientService(IIngredientsRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }
        public async Task<IEnumerable<IngredientResponseDto>> ListAllAsync()
        {
            var ingredients = await _ingredientRepository.ListAllAsync();
            var dto = ingredients.MapToDto();

            return dto;
        }

        public async Task<IngredientResponseDto> GetByIdAsync(Guid id)
        {
            var ingredient = await _ingredientRepository.GetByIdAsync(id);

            if (ingredient == null)
            {
                return null;
            }
            var dto = ingredient.MapToDto();
            return dto;
        }

        public async Task<IngredientResponseDto> AddAsync(IngredientRequestDto ingredientsRequestDto)
        {
            var ingredient = new Ingredient { Id = ingredientsRequestDto.Id, Name = ingredientsRequestDto.Name };
            var result = await _ingredientRepository.AddAsync(ingredient);
            var dto = result.MapToDto();
            return dto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _ingredientRepository.DeleteAsync(id);
        }

        public async Task<IngredientResponseDto> UpdateAsync(IngredientRequestDto ingredientsRequestDto)
        {
            var ingredient = new Ingredient{Id = ingredientsRequestDto.Id, Name = ingredientsRequestDto.Name};
            var result = await _ingredientRepository.UpdateAsync(ingredient);
            var dto = ingredient.MapToDto();
            return dto;
        }
    }
}
