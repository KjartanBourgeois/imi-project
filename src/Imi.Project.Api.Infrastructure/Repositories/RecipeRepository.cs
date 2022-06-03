using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class RecipeRepository : EfRepository<Recipe>, IRecipeRepository
    {
        public RecipeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public override async Task<Recipe> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(c => c.Id.Equals(id));
        }

        public override IQueryable<Recipe> GetAllAsync()
        {
            return _dbContext.Recipes.AsNoTracking()
                    .Include(ri => ri.RecipeIngredients)
                        .ThenInclude(i => i.Ingredient)
                    .Include(c => c.Category)
                    .Include(t => t.Theme)
                    .Include(k => k.Kitchen);
        }

        public async Task<Recipe> GetIngredientsByRecipeIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(r => r.Id.Equals(id));

        }
    }
}
