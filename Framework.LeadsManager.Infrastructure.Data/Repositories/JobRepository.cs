using Framework.LeadsManager.Domain.Entities;
using Framework.LeadsManager.Domain.Interfaces;
using Framework.LeadsManager.Infrastructure.Data.Context;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Framework.LeadsManager.Infrastructure.Data.Repositories
{
    public class JobRepository : Repository<Job>, IJobRepository
    {
        private readonly RepositoryContext _contexto;
        public JobRepository(RepositoryContext contexto) : base(contexto)
        {
            _contexto = contexto;
        }
        public async override Task<IEnumerable<Job>> GetAllAsync()
        {
            return await _contexto.Job
                .Include(p => p.Category)
                .Include(p => p.Lead)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
