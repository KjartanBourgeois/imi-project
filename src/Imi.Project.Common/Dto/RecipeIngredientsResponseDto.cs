using Imi.Project.Common.Dto.Base;
using System.Collections.Generic;

namespace Imi.Project.Common.Dto
{
    public class RecipeIngredientsResponseDto : DtoBase
    {
        public string RecipeName { get; set; }
        public IEnumerable<IngredientNameResponseDto> Ingredients { get; set; }
    }
}