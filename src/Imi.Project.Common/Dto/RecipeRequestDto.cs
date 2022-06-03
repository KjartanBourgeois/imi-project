using Imi.Project.Common.Dto.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Common.Dto
{
    public class RecipeRequestDto : DtoBase
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        [Required]
        public Guid KitchenId { get; set; }

        [Required]
        public Guid ThemeId { get; set; }

        [Required]
        public string Instructions { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public Uri WebsiteLink { get; set; }

        [Required]
        public int NumberOfPersons { get; set; }
    }
}