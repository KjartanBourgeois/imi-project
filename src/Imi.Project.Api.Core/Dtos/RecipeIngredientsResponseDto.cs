using Imi.Project.Api.Core.Dtos.Base;
using Imi.Project.Api.Core.Entities;
using System;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Dtos
{
    public class RecipeIngredientsResponseDto : DtoBase
    {
        public string RecipeName { get; set; }
        public IEnumerable<IngredientNameResponseDto> Ingredients { get; set; }
    }
}