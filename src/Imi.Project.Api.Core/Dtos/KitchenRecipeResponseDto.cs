using Imi.Project.Api.Core.Dtos.Base;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Dtos
{
    public class KitchenRecipeResponseDto : DtoBase
    {
        public string KitchenName { get; set; }
        public IEnumerable<RecipeNameResponseDto> Recipes { get; set; }
    }
}
