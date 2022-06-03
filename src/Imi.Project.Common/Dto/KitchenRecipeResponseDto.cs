using Imi.Project.Common.Dto.Base;
using System.Collections.Generic;

namespace Imi.Project.Common.Dto
{
    public class KitchenRecipeResponseDto : DtoBase
    {
        public string KitchenName { get; set; }
        public IEnumerable<RecipeNameResponseDto> Recipes { get; set; }
    }
}