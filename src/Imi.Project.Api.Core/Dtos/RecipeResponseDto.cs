using Imi.Project.Api.Core.Dtos.Base;
using System;

namespace Imi.Project.Api.Core.Dtos
{
    public class RecipeResponseDto : DtoBase
    {
        public string Name { get; set; }
        public CategoryResponseDto Category { get; set; }
        public KitchenResponseDto Kitchen { get; set; }
        public ThemeResponseDto Theme { get; set; }
        public string Instructions { get; set; }
        public string Image { get; set; }
        public Uri WebsiteLink { get; set; }
        public int NumberOfPersons { get; set; }
    }
}