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
    public class ThemeRepository : EfRepository<Theme>, IThemeRepository
    {
        public ThemeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
        public override async Task<Theme> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(k => k.Id.Equals(id));

        }

        public override IQueryable<Theme> GetAllAsync()
        {
            return _dbContext.Themes.AsNoTracking()
                    .Include(r => r.Recipes);
        }
        public async Task<IEnumerable<Theme>> GetRecipeByThhemeIdAsync(Guid id)
        {
            return await GetAllAsync().Where(t => t.Id.Equals(id)).ToListAsync();
        }
    }
}
