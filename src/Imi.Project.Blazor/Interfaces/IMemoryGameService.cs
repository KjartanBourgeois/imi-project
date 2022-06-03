using Imi.Project.Core.Models.MemoryGame;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Interfaces
{
    public interface IMemoryGameService
    {
        Task<List<RecipeCard>> GetRecipeCards(DifficultyLevel difficultyLevel);
    }
}