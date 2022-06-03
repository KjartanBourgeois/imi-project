using System;
using System.Collections.Generic;
using System.Linq;

namespace Imi.Project.Core.Models.MemoryGame
{
    public class GameBoard
    {
        public int NumberOfRecipeCards { get; set; }
        public decimal Score { get; set; }
        public DifficultyLevel difficultyLevel { get; set; }
        public List<RecipeCard> RecipeCards { get; set; }
        public List<RecipeCard> PlayCards { get; set; }

        public void RandomiseCards()
        {
            PlayCards = new List<RecipeCard>();
            Random rnd = new Random();

            PlayCards = RecipeCards.OrderBy(x => rnd.Next()).ToList();
        }
    }
}