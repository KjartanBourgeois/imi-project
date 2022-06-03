using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using System;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories
{
    public interface IRecipeRepository : IRepository<Recipe>
    {
        Task<Recipe> GetIngredientsByRecipeIdAsync(Guid id);
    }
}
