using Imi.Project.Common.Dto;
using Imi.Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Core.Helpers.Mapper
{
    public static class DtoMapper
    {
        #region To Category DTOs

        public static CategoryRequestDto MapToCategoryRequestDto(this RecipeCategoryItem category)
        {
            return new CategoryRequestDto
            {
                Id = category.Id,
                Name = category.Name,
            };
        }

        #endregion To Category DTOs

        #region To Kitchen DTOs

        public static KitchenRequestDto MapToKitchenRequestDto(this RecipeKitchenItem kitchen)
        {
            return new KitchenRequestDto
            {
                Id = kitchen.Id,
                Name = kitchen.Name,
            };
        }

        #endregion To Kitchen DTOs

        #region To Theme DTOs

        public static ThemeRequestDto MapToThemeRequestDto(this RecipeThemeItem theme)
        {
            return new ThemeRequestDto
            {
                Id = theme.Id,
                Name = theme.Name,
            };
        }

        #endregion To Theme DTOs

        #region To Recipe DTOs

        public static RecipeRequestDto MapToRecipeRequestDto(this RecipeItem recipe)
        {
            return new RecipeRequestDto
            {
                Id = recipe.Id,
                Name = recipe.Title,
                CategoryId = recipe.CategoryId,
                KitchenId = recipe.KitchenId,
                ThemeId = recipe.ThemeId,
                Instructions = "",
                Image = recipe.ImageLink,
                WebsiteLink = new Uri(recipe.WebsiteLink),
                NumberOfPersons = recipe.NumberOfPersons,
            };
        }

        #endregion To Recipe DTOs
    }
}