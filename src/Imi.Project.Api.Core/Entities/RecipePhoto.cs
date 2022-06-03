using System;

namespace Imi.Project.Api.Core.Entities
{
    public class RecipePhoto
    {
        public Guid Id { get; set; }
        public string ImageLink { get; set; }
        public Guid RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public bool HighlightedImage { get; set; }
    }
}