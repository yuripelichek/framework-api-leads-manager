using Framework.LeadsManager.Domain.Entities;
using Framework.LeadsManager.Domain.Interfaces;
using Framework.LeadsManager.Domain.Interfaces.Services;

namespace Framework.LeadsManager.Domain.Services
{
    public class ClientService : Service<Client>, IClientService
    {
        private readonly IClientRepository Repository;

        public ClientService(IClientRepository repository) : base(repository) => Repository = repository;
    }
}
