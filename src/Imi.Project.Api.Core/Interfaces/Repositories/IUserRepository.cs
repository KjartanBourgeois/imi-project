using Imi.Project.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(Guid id);
        IQueryable<User> GetAllAsync();
        Task<IEnumerable<User>> ListAllAsync();
        Task<User> UpdateAsync(User entity);
        Task<User> AddAsync(User entity);
        Task<User> DeleteAsync(User entity);
        Task<User> DeleteAsync(Guid id);
    }
}
