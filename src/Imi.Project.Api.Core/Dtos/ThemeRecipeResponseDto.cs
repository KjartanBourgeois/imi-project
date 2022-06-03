using Imi.Project.Api.Core.Dtos.Base;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Dtos
{
    public class ThemeRecipeResponseDto : DtoBase
    {
        public string ThemeName { get; set; }
        public IEnumerable<RecipeNameResponseDto> Recipes { get; set; }

    }
}
