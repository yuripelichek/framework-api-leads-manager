using Framework.LeadsManager.Domain.Entities;
using Framework.LeadsManager.Domain.Interfaces;
using Framework.LeadsManager.Infrastructure.Data.Context;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Framework.LeadsManager.Infrastructure.Data.Repositories
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        private readonly RepositoryContext _contexto;    
        public ClientRepository(RepositoryContext contexto) : base(contexto) {
            _contexto = contexto;
        }
        public async override Task<IEnumerable<Client>> GetAllAsync()
        {
            return await _contexto.Client.Include(p => p.Addreess).ToListAsync();
        }
    }
}
