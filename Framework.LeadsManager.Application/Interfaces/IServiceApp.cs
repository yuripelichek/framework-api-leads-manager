using System.Collections.Generic;
using System.Threading.Tasks;

namespace Framework.LeadsManager.Application.Interfaces
{
    public interface IServiceApp<T> where T : class
    {
        Task AddAsync(T item);

        Task UpdateAsync(T item);

        Task RemoveAsync(T item);

        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);
    }
}
