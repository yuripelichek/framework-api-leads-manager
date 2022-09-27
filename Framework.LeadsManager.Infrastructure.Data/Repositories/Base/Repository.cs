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
        protected readonly RepositoryContext _context;
        public Repository(RepositoryContext contexto) =>
            _context = contexto;

        public async Task<TEntity> GetById(int id) =>
            await _context.Set<TEntity>().FindAsync(id);

        public virtual async Task<TEntity> CreateAsync(TEntity obj)
        {
            var entity = (await _context.AddAsync(obj)).Entity;
            await _context.SaveChangesAsync();
            
            return entity;
        }
        public virtual async Task<TEntity> UpdateAsync(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return await Task.FromResult(obj);
        }
        public virtual async Task RemoveAsync(int id) =>
            _context.Remove(await GetById(id));
        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }
    }
}
