using Imi.Project.Common.Dto;
using Imi.Project.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Core.Helpers.Mapper
{
    public static class KitchenMapper
    {
        public static RecipeKitchenListItem[] MapToKitchenListItem(this IEnumerable<KitchenResponseDto> kitchens)
        {
            var result = kitchens.Select(x => x.MapToKitchenListItem());
            return result.ToArray();
        }

        public static RecipeKitchenListItem MapToKitchenListItem(this KitchenResponseDto kitchen)
        {
            return new RecipeKitchenListItem
            {
                Id = kitchen.Id,
                Name = kitchen.Name,
            };
        }

        public static RecipeKitchenItem MapToKitchenItem(this KitchenResponseDto kitchen)
        {
            return new RecipeKitchenItem
            {
                Id = kitchen.Id,
                Name = kitchen.Name,
            };
        }

        public static InputSelectItem[] MapToKitchenInputSelectItem(this KitchenResponseDto kitchen)
        {
            List<InputSelectItem> result = new List<InputSelectItem>();
            var input = new InputSelectItem
            {
                Value = kitchen.Id,
                Label = kitchen.Name,
            };

            result.Add(input);

            return result.ToArray();
        }
    }
}