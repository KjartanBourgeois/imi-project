using Imi.Project.Common.Dto;
using Imi.Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Core.Helpers.Mapper
{
    public static class ThemeMapper
    {
        public static RecipeThemeListItem[] MapToThemeListItem(this IEnumerable<ThemeResponseDto> themes)
        {
            var result = themes.Select(x => x.MapToThemeListItem());
            return result.ToArray();
        }

        public static RecipeThemeListItem MapToThemeListItem(this ThemeResponseDto theme)
        {
            return new RecipeThemeListItem
            {
                Id = theme.Id,
                Name = theme.Name,
            };
        }

        public static RecipeThemeItem MapToThemeItem(this ThemeResponseDto theme)
        {
            return new RecipeThemeItem
            {
                Id = theme.Id,
                Name = theme.Name,
            };
        }

        public static InputSelectItem[] MapToThemeInputSelectItem(this ThemeResponseDto theme)
        {
            List<InputSelectItem> result = new List<InputSelectItem>();
            var input = new InputSelectItem
            {
                Value = theme.Id,
                Label = theme.Name,
            };

            result.Add(input);

            return result.ToArray();
        }
    }
}