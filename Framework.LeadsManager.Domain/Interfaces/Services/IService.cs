using Framework.LeadsManager.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Framework.LeadsManager.Domain.Interfaces
{
    public interface IService<TEntity> where TEntity : Entity
    {
        Task<TEntity> CreateAsync(TEntity obj);
        Task<IEnumerable<TEntity>> CreateAsync(IEnumerable<TEntity> obj);
        Task<TEntity> UpdateAsync(TEntity obj);
        Task RemoveAsync(int id);
    }
}