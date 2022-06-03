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
    public class IngredientsRepository : EfRepository<Ingredient>, IIngredientsRepository
    {
        public IngredientsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public override async Task<Ingredient> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(k => k.Id.Equals(id));

        }

        public override IQueryable<Ingredient> GetAllAsync()
        {
            return _dbContext.Ingredients.AsNoTracking();
        }

    }
}
