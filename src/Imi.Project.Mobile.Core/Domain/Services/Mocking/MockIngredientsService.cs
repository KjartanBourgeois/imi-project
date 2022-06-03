using Imi.Project.Mobile.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Core.Domain.Services.Mocking
{
    public class MockIngredientsService : IIngredientsService
    {
        private static List<Ingredient>ingredientsList = new List<Ingredient>
        {
            //ingredients nasi goreng
            new Ingredient
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                Name = "Champignon",
                Amount = 31,
                Unit = "gram",
                RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000001")
            },

            new Ingredient
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                Name = "Witte kool",
                Amount = 23,
                Unit = "gram",
                RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000001")
            },

            //ingredients brusselse wafels
            new Ingredient
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                Name = "Eieren",
                Amount = 2,
                Unit = "",
                RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000002")
            },
            new Ingredient
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
                Name = "VBoter",
                Amount = 60,
                Unit = "gram",
                RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000002")
            },
            new Ingredient
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
                Name = "Verse gist",
                Amount = 20,
                Unit = "gram",
                RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000002")
            },
            new Ingredient
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
                Name = "Volle Melk",
                Amount = 20,
                Unit = "cl",
                RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000002")
            },
            new Ingredient
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
                Name = "Zelfrijzende bloem",
                Amount = 200,
                Unit = "gram",
                RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000002")
            },
            new Ingredient
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
                Name = "Zout",
                Unit = "snuifje",
                RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000002")
            },
            new Ingredient
            {
                Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
                Name = "Vanillesuiker",
                Amount = 15,
                Unit = "gram",
                RecipeId = Guid.Parse("00000000-0000-0000-0000-000000000002")
            }
        };

        public async Task<IQueryable<Ingredient>> GetAllByRecipeId( Guid id)
        {
            var ingredients = ingredientsList.Where(x => x.RecipeId.Equals(id)).AsQueryable();
            return await Task.FromResult(ingredients);
        }
    }
}
