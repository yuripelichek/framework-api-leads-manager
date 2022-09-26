using Framework.LeadsManager.Domain.Entities;
using Framework.LeadsManager.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Framework.LeadsManager.Domain.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : Entity
    {
        private readonly IRepository<TEntity> Repository;

        public Service(IRepository<TEntity> repository) => Repository = repository;

        public virtual async Task<TEntity> CreateAsync(TEntity obj) =>
            await Repository.CreateAsync(obj);

        public virtual async Task<IEnumerable<TEntity>> CreateAsync(IEnumerable<TEntity> obj) =>
            await Repository.CreateAsync(obj);

        public virtual async  Task<TEntity> UpdateAsync(TEntity obj) =>
            await Task.FromResult(await Repository.UpdateAsync(obj));

        public virtual async Task RemoveAsync(int id) =>
            await Repository.RemoveAsync(id);
    }
}