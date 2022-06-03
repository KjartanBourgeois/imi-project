using Imi.Project.Api.Core.Entities.Base;
using System;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Entities
{
    public class Recipe : EntityBase
    {
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<RecipeIngredients> RecipeIngredients { get; set; }
        public ICollection<RecipePhoto> RecipePhotos { get; set; }
        public Guid KitchenId { get; set; }
        public Kitchen Kitchen { get; set; }
        public string Instructions { get; set; }
        public Guid ThemeId { get; set; }
        public Theme Theme { get; set; }
        public string Image { get; set; }
        public Uri WebsiteLink { get; set; }
        public int NumberOfPersons { get; set; }
    }
}