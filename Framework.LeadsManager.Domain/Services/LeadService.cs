using Framework.LeadsManager.Domain.Entities;
using Framework.LeadsManager.Domain.Interfaces;
using Framework.LeadsManager.Domain.Interfaces.Services;

namespace Framework.LeadsManager.Domain.Services
{
    public class LeadService : Service<Lead>, ILeadService
    {
        private readonly ILeadRepository Repository;

        public LeadService(ILeadRepository repository) : base(repository) => Repository = repository;
    }
}
