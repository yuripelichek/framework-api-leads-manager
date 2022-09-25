using System.Collections.Generic;
using System.Threading.Tasks;
using Framework.LeadsManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Framework.LeadsManager.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        Task<TEntity> Create(TEntity obj);
        Task<IEnumerable<TEntity>> Create(IEnumerable<TEntity> obj);
        TEntity Update(TEntity obj);
        Task Remove(int id);
    }
}
