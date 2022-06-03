using Imi.Project.Common.Dto;
using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class MockRecipeService
    {
        private static List<Recipe> recipesList = new List<Recipe>
        {
            new Recipe
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                Name = "Nasi Goreng",
                Category = "Hoofdgerecht",
                NumberOfPersons = 1,
                Instructions = "Voeg 1 rode peper en 16 gr geschilde gember toe aan de mengbeker 3 sec/snelheid 8; Schraap naar beneden voeg 2 uien en 2 teentjes knoflook toe 5 sec/snelheid 5",
                Image = "https://www.alleskunner.be/images/nasigoreng.png",
                WebsiteLink = new Uri("https://www.alleskunner.be/recepten/nasigoreng.php"),
            },

            new Recipe
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                Name = "Brusselse Wafels",
                Category = "Dessert",
                NumberOfPersons = 4,
                Instructions = "Split de eieren en voeg de eiwitten toe aan de mengbeker, voeg de vlinder toe 2 min/snelheid 4; haal opgeklopt eiwit eruit en zet opzij",
                Image="https://www.alleskunner.be/images/brusselse-wafels.png",
                WebsiteLink = new Uri("https://www.alleskunner.be/recepten/brusselse-wafels.php")
            }
        };

        public Task<Recipe> AddRecipe(Recipe recipe)
        {
            recipesList.Add(recipe);
            return Task.FromResult(recipe);
        }

        public async Task<Recipe> DeleteRecipe(Guid recipeId)
        {
            var oldRecipe = recipesList.FirstOrDefault(r => r.Id == recipeId);
            recipesList.Remove(oldRecipe);
            return await Task.FromResult(oldRecipe);
        }

        //public async Task<RecipeResponseDto> GetRecipe(Guid recipeId)
        //{
        //    var recipe = recipesList.FirstOrDefault(r => r.Id.Equals(recipeId));
        //    return await Task.FromResult(recipe);
        //}

        public async Task<Recipe> UpdateRecipe(Recipe recipe)
        {
            var oldRecipe = recipesList.FirstOrDefault(r => r.Id.Equals(recipe.Id));
            recipesList.Remove(oldRecipe);
            recipesList.Add(recipe);
            return await Task.FromResult(recipe);
        }

        public async Task<IQueryable<Recipe>> GetAllRecipes()
        {
            var recipes = recipesList.AsQueryable();
            return await Task.FromResult(recipes);
        }

        public Task<RecipeResponseDto> GetRecipe(Guid recipeId)
        {
            throw new NotImplementedException();
        }
    }
}