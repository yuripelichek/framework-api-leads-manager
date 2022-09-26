﻿using Framework.LeadsManager.Domain.Entities;
using Framework.LeadsManager.Domain.Interfaces;
using Framework.LeadsManager.Infrastructure.Data.Context;

namespace Framework.LeadsManager.Infrastructure.Data.Repositories
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        public ClientRepository(RepositoryContext contexto) : base(contexto) { }
    }
}
