using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services
{
    public interface ICRUDService<T, K>
    {
        Task<T[]> GetList();

        Task<K> GetNew();

        Task<K> Get(Guid id);

        Task<K> Create(K item, string token);

        Task<K> Update(K item, string token);

        Task<K> Delete(Guid id, string token);
    }
}