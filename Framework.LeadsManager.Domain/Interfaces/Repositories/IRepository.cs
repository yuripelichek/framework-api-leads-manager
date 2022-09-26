using System.Collections.Generic;
using System.Threading.Tasks;
using Framework.LeadsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Framework.LeadsManager.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        Task<TEntity> CreateAsync(TEntity obj);
        Task<IEnumerable<TEntity>> CreateAsync(IEnumerable<TEntity> obj);
        Task<TEntity> UpdateAsync(TEntity obj);
        Task RemoveAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
