using Imi.Project.Common.Dto.Base;
using System.Collections.Generic;

namespace Imi.Project.Common.Dto
{
    public class CategoryRecipeResponseDto : DtoBase
    {
        public string CategoryName { get; set; }
        public IEnumerable<RecipeNameResponseDto> Recipes { get; set; }
    }
}