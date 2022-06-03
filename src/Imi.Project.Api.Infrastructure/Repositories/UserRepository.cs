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
    public class UserRepository : IUserRepository
    {
        protected readonly ApplicationDbContext _dbContext;

        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> AddAsync(User entity)
        {
            await _dbContext.Set<User>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<User> DeleteAsync(User entity)
        {
            _dbContext.Set<User>().Remove(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<User> DeleteAsync(Guid id)
        {
            var entity = await GetByIdAsync(id);
            await DeleteAsync(entity);
            return entity;
        }

        public virtual IQueryable<User> GetAllAsync()
        {
            return _dbContext.Set<User>().AsNoTracking();
        }

        public virtual async Task<User> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<User>().FindAsync(id);
        }

        public async Task<IEnumerable<User>> ListAllAsync()
        {
            return await GetAllAsync().ToListAsync();
        }

        public async Task<User> UpdateAsync(User entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return entity;
        }

    }
}
