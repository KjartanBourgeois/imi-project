using System;
using System.ComponentModel.DataAnnotations;

namespace Imi.Project.Core.Models
{
    public class RecipeItem
    {
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        public Guid CategoryId { get; set; }
        public InputSelectItem[] Categories { get; set; }
        public Guid KitchenId { get; set; }
        public InputSelectItem[] Kitchens { get; set; }
        public Guid ThemeId { get; set; }
        public InputSelectItem[] Themes { get; set; }
        public int NumberOfPersons { get; set; }
        public string ImageLink { get; set; }
        public string WebsiteLink { get; set; }
    }
}