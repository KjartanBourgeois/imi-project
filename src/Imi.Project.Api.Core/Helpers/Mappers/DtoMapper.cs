using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Imi.Project.Api.Core.Helpers.Mappers
{
    public static class DtoMapper
    {
        #region category to dto mapper

        public static IEnumerable<CategoryResponseDto> MapToDto(this IEnumerable<Category> categoryEntities)
        {
            return categoryEntities.Select(x => x.MapToDto());
        }

        public static CategoryResponseDto MapToDto(this Category categoryEntity)
        {
            return new CategoryResponseDto
            {
                Id = categoryEntity.Id,
                Name = categoryEntity.Name,
            };
        }

        public static IEnumerable<CategoryRecipeResponseDto> MapToCategoryRecipeDto(this IEnumerable<Category> categoryEntities)
        {
            return categoryEntities.Select(x => x.MapToCategoryRecipeDto());
        }

        public static CategoryRecipeResponseDto MapToCategoryRecipeDto(this Category categoryEntity)
        {
            return new CategoryRecipeResponseDto
            {
                Id = categoryEntity.Id,
                CategoryName = categoryEntity.Name,
                Recipes = categoryEntity.Recipes.MapToRecipeNameDto()
            };
        }

        #endregion category to dto mapper

        #region ingredient to dto mapper

        public static IEnumerable<IngredientResponseDto> MapToDto(this IEnumerable<Ingredient> ingredientsEntities)
        {
            return ingredientsEntities.Select(x => x.MapToDto());
        }

        public static IngredientResponseDto MapToDto(this Ingredient ingredientEntity)
        {
            return new IngredientResponseDto
            {
                Id = ingredientEntity.Id,
                Name = ingredientEntity.Name,
            };
        }

        public static IEnumerable<IngredientNameResponseDto> MapToIngredientNameDto(this IEnumerable<Ingredient> ingredientsEntities)
        {
            return ingredientsEntities.Select(x => x.MapToIngredientNameDto());
        }

        public static IngredientNameResponseDto MapToIngredientNameDto(this Ingredient ingredientEntity)
        {
            return new IngredientNameResponseDto
            {
                Name = ingredientEntity.Name,
            };
        }

        #endregion ingredient to dto mapper

        #region kitchen to dto mapper

        public static IEnumerable<KitchenResponseDto> MapToDto(this IEnumerable<Kitchen> kitchenEntities)
        {
            return kitchenEntities.Select(x => x.MapToDto());
        }

        public static KitchenResponseDto MapToDto(this Kitchen categoryEntity)
        {
            return new KitchenResponseDto
            {
                Id = categoryEntity.Id,
                Name = categoryEntity.Name,
            };
        }

        public static IEnumerable<KitchenRecipeResponseDto> MapToKitchenRecipeDto(this IEnumerable<Kitchen> kitchenEntities)
        {
            return kitchenEntities.Select(x => x.MapToKitchenRecipeDto());
        }

        public static KitchenRecipeResponseDto MapToKitchenRecipeDto(this Kitchen kitchenEntity)
        {
            return new KitchenRecipeResponseDto
            {
                Id = kitchenEntity.Id,
                KitchenName = kitchenEntity.Name,
                Recipes = kitchenEntity.Recipes.MapToRecipeNameDto()
            };
        }

        #endregion kitchen to dto mapper

        #region theme to dto mapper

        public static IEnumerable<ThemeResponseDto> MapToDto(this IEnumerable<Theme> themeEntities)
        {
            return themeEntities.Select(x => x.MapToDto());
        }

        public static ThemeResponseDto MapToDto(this Theme themeEntity)
        {
            return new ThemeResponseDto
            {
                Id = themeEntity.Id,
                Name = themeEntity.Name,
            };
        }

        public static IEnumerable<ThemeRecipeResponseDto> MapToThemeRecipeDto(this IEnumerable<Theme> themeEntities)
        {
            return themeEntities.Select(x => x.MapToThemeRecipeDto());
        }

        public static ThemeRecipeResponseDto MapToThemeRecipeDto(this Theme themeEntity)
        {
            return new ThemeRecipeResponseDto
            {
                Id = themeEntity.Id,
                ThemeName = themeEntity.Name,
                Recipes = themeEntity.Recipes.MapToRecipeNameDto()
            };
        }

        #endregion theme to dto mapper

        #region user to dto mapper

        public static IEnumerable<UserResponseDto> MapToDto(this IEnumerable<User> userEntities)
        {
            return userEntities.Select(x => x.MapToDto());
        }

        public static UserResponseDto MapToDto(this User userEntity)
        {
            return new UserResponseDto
            {
                UserName = userEntity.UserName,
                Email = userEntity.Email,
                DoB = userEntity.DoB,
                TermsAndConditions = userEntity.TermsAndConditions
            };
        }

        #endregion user to dto mapper

        //Recipes

        #region recipe to dto mapper

        public static IEnumerable<RecipeResponseDto> MapToDto(this IEnumerable<Recipe> recipeEntities)
        {
            return recipeEntities.Select(x => x.MapToDto());
        }

        public static RecipeResponseDto MapToDto(this Recipe recipeEntity)
        {
            return new RecipeResponseDto
            {
                Id = recipeEntity.Id,
                Name = recipeEntity.Name,
                Category = recipeEntity.Category.MapToDto(),
                Kitchen = recipeEntity.Kitchen.MapToDto(),
                Theme = recipeEntity.Theme.MapToDto(),
                Image = recipeEntity.Image,
                Instructions = recipeEntity.Instructions,
                NumberOfPersons = recipeEntity.NumberOfPersons,
                WebsiteLink = recipeEntity.WebsiteLink,
            };
        }

        public static RecipeIngredientsResponseDto MapToRecipeIngredientsDto(this Recipe recipeEntity)
        {
            return new RecipeIngredientsResponseDto
            {
                Id = recipeEntity.Id,
                RecipeName = recipeEntity.Name,
                Ingredients = recipeEntity.RecipeIngredients.Select(x => x.Ingredient.MapToIngredientNameDto())
            };
        }

        public static IEnumerable<RecipeNameResponseDto> MapToRecipeNameDto(this IEnumerable<Recipe> recipeEntities)
        {
            return recipeEntities.Select(x => x.MapToRecipeNameDto());
        }

        public static RecipeNameResponseDto MapToRecipeNameDto(this Recipe recipeEntity)
        {
            return new RecipeNameResponseDto
            {
                Name = recipeEntity.Name
            };
        }

        #endregion recipe to dto mapper
    }
}