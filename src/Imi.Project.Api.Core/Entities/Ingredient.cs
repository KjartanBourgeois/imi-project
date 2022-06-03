using Imi.Project.Api.Core.Entities.Base;
using System;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Entities
{
    public class Ingredient : EntityBase
    {
        public string Name { get; set; }
        public ICollection<RecipeIngredients> RecipeIngredients { get; set; }
    }
}