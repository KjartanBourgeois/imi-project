using Imi.Project.Common.Dto.Base;
using System.Collections.Generic;

namespace Imi.Project.Common.Dto
{
    public class ThemeRecipeResponseDto : DtoBase
    {
        public string ThemeName { get; set; }
        public IEnumerable<RecipeNameResponseDto> Recipes { get; set; }
    }
}