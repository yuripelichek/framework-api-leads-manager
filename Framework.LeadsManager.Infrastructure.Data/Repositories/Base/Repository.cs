using Framework.LeadsManager.Domain.Entities;
using Framework.LeadsManager.Domain.Interfaces;
using Framework.LeadsManager.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Framework.LeadsManager.Infrastructure.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly RepositoryContext Contexto;

        public IUnitOfWork UnitOfWork => Contexto;

        public Repository(RepositoryContext contexto) =>
            Contexto = contexto;

        private async Task<TEntity> GetById(int id) =>
            await Contexto.Set<TEntity>().FindAsync(id);

        public virtual async Task<TEntity> CreateAsync(TEntity obj)
        {
            var entity = (await Contexto.AddAsync(obj)).Entity;
            await Contexto.SaveChangesAsync();
            
            return entity;
        }

        public virtual async Task<IEnumerable<TEntity>> CreateAsync(IEnumerable<TEntity> obj)
        {
            await Contexto.AddRangeAsync(obj);
            await Contexto.SaveChangesAsync();
            return obj;
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity obj)
        {
            Contexto.Entry(obj).State = EntityState.Modified;
            return await Task.FromResult(obj);
        }
        public virtual async Task RemoveAsync(int id) =>
            Contexto.Remove(await GetById(id));
        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await Contexto.Set<TEntity>().ToListAsync();
        }
    }
}
