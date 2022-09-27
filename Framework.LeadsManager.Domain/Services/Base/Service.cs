using Framework.LeadsManager.Domain.Entities;
using Framework.LeadsManager.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Framework.LeadsManager.Domain.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : Entity
    {
        private readonly IRepository<TEntity> _repository;
        public Service(IRepository<TEntity> repository) => _repository = repository;

        public virtual async Task<TEntity> CreateAsync(TEntity obj) =>
            await _repository.CreateAsync(obj);
        public virtual async Task<TEntity> UpdateAsync(TEntity obj) =>
            await Task.FromResult(await _repository.UpdateAsync(obj));

        public virtual async Task RemoveAsync(int id) =>
            await _repository.RemoveAsync(id);
        public virtual async Task<IEnumerable<TEntity>> GetAllAsync() => 
            await _repository.GetAllAsync();

        public async Task<TEntity> GetById(int id) =>
            await _repository.GetById(id);
    }
}