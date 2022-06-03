using System;

namespace Imi.Project.Core.Models.MemoryGame
{
    public class RecipeCard
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
    }
}