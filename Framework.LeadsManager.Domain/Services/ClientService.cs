using Framework.LeadsManager.Domain.Entities;
using Framework.LeadsManager.Domain.Interfaces;
using Framework.LeadsManager.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace Framework.LeadsManager.Domain.Services
{
    public class ClientService : Service<Client>, IClientService
    {
        public ClientService(IClientRepository repository) : base(repository) { }

    }
}
