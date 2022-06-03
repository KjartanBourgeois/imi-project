using System;

namespace Imi.Project.Core.Models
{
    public class RecipeListItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Kitchen { get; set; }
        public string Theme { get; set; }
        public string ImageURL { get; set; }
        public string WebsiteURL { get; set; }
        public int NumberOfPersons { get; set; }
    }
}