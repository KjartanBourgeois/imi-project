using System;

namespace Imi.Project.Api.Core.Entities
{
    public class RecipeIngredients
    {
        //Foreign key of the Recipe entity
        public Guid RecipeId { get; set; }

        //Foreign key of the Ingredient entity
        public Guid IngredientId { get; set; }

        //Navigation property to Recipe entity
        public Recipe Recipe { get; set; }

        //Navigation property to Ingredient entity
        public Ingredient Ingredient { get; set; }

        public double Amount { get; set; }
        public string Unit { get; set; }
    }
}