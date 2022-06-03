using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class KitchenRepository : EfRepository<Kitchen>, IKitchenRepository
    {
        public KitchenRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public override async Task<Kitchen> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(k => k.Id.Equals(id));

        }

        public override IQueryable<Kitchen> GetAllAsync()
        {
            return _dbContext.Kitchens.AsNoTracking()
                    .Include(r => r.Recipes);
        }
        public async Task<IEnumerable<Kitchen>> GetRecipeByKitchenIdAsync(Guid id)
        {
            return await GetAllAsync().Where(c => c.Id.Equals(id)).ToListAsync();
        }
    }
}
