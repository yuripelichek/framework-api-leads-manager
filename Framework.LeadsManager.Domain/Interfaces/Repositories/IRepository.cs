using Framework.LeadsManager.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Framework.LeadsManager.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        Task<TEntity> CreateAsync(TEntity obj);
        Task<TEntity> UpdateAsync(TEntity obj);
        Task RemoveAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetById(int id);
    }
}
