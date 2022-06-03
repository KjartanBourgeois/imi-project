using Imi.Project.Common.Dto;
using Imi.Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Core.Helpers.Mapper
{
    public static class CategoryMapper
    {
        public static RecipeCategoryListItem[] MapToCategoryListItem(this IEnumerable<CategoryResponseDto> categories)
        {
            var result = categories.Select(x => x.MapToCategoryListItem());
            return result.ToArray();
        }

        public static RecipeCategoryListItem MapToCategoryListItem(this CategoryResponseDto category)
        {
            return new RecipeCategoryListItem
            {
                Id = category.Id,
                Name = category.Name,
            };
        }

        public static RecipeCategoryItem MapToCategoryItem(this CategoryResponseDto category)
        {
            return new RecipeCategoryItem
            {
                Id = category.Id,
                Name = category.Name,
            };
        }

        public static InputSelectItem[] MapToCategoryInputSelectItem(this CategoryResponseDto category)
        {
            List<InputSelectItem> result = new List<InputSelectItem>();
            var input = new InputSelectItem
            {
                Value = category.Id,
                Label = category.Name,
            };

            result.Add(input);

            return result.ToArray();
        }
    }
}