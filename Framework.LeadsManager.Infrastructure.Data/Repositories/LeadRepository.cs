using Framework.LeadsManager.Domain.Entities;
using Framework.LeadsManager.Domain.Interfaces;
using Framework.LeadsManager.Infrastructure.Data.Context;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Framework.LeadsManager.Infrastructure.Data.Repositories
{
    public class LeadRepository : Repository<Lead>, ILeadRepository
    {
        private readonly RepositoryContext _contexto;
        public LeadRepository(RepositoryContext contexto) : base(contexto)
        {
            _contexto = contexto;
        }
        public async override Task<IEnumerable<Lead>> GetAllAsync()
        {
            return await _contexto.Lead    
                .Include(p => p.Client).ThenInclude(p => p.Addreess)
                .Include(p => p.Job).ThenInclude(p => p.Category)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
