using Imi.Project.Api.Core.Dtos.Base;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Dtos
{
    public class CategoryRecipeResponseDto : DtoBase
    {
        public string CategoryName { get; set; }
        public IEnumerable<RecipeNameResponseDto> Recipes { get; set; }
    }
}
