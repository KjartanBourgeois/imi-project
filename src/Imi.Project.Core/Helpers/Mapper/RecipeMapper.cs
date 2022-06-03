using Imi.Project.Common.Dto;
using Imi.Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Core.Helpers.Mapper
{
    public static class RecipeMapper
    {
        public static RecipeListItem[] MapToRecipeListItem(this IEnumerable<RecipeResponseDto> recipes)
        {
            var result = recipes.Select(x => x.MapToRecipeListItem());
            return result.ToArray();
        }

        public static RecipeListItem MapToRecipeListItem(this RecipeResponseDto recipe)
        {
            return new RecipeListItem
            {
                Id = recipe.Id,
                Title = recipe.Name,
                Category = recipe.Category.Name,
                Kitchen = recipe.Kitchen.Name,
                Theme = recipe.Theme.Name,
                ImageURL = recipe.Image,
                WebsiteURL = recipe.WebsiteLink.ToString(),
                NumberOfPersons = recipe.NumberOfPersons
            };
        }

        public static RecipeItem MapToRecipeItem(this RecipeResponseDto recipe)
        {
            return new RecipeItem
            {
                Id = recipe.Id,
                Title = recipe.Name,
                Categories = recipe.Category.MapToCategoryInputSelectItem(),
                CategoryId = recipe.Category.Id,
                Kitchens = recipe.Kitchen.MapToKitchenInputSelectItem(),
                KitchenId = recipe.Kitchen.Id,
                Themes = recipe.Theme.MapToThemeInputSelectItem(),
                ThemeId = recipe.Theme.Id,
                NumberOfPersons = recipe.NumberOfPersons,
                ImageLink = recipe.Image,
                WebsiteLink = recipe.WebsiteLink.ToString(),
            };
        }
    }
}