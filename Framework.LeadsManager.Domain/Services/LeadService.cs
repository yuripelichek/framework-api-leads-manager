using Framework.LeadsManager.Domain.Entities;
using Framework.LeadsManager.Domain.Interfaces;
using Framework.LeadsManager.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace Framework.LeadsManager.Domain.Services
{
    public class LeadService : Service<Lead>, ILeadService
    {
        private readonly ILeadRepository _repository;
        public LeadService(ILeadRepository repository) : base(repository) => _repository = repository;
        public async Task<Lead> AcceptLeadAsync(Lead lead)
        {
           lead.Approved = true;
           lead.Job.PriceWithDiscount = lead.Job.Price > 500 ? lead.Job.Price * (decimal)0.9 : lead.Job.Price;
           return await _repository.UpdateAsync(lead);
        }
        public async Task<Lead> DeclineLeadAsync(Lead lead)
        {
            lead.Approved = false;
            return await _repository.UpdateAsync(lead);
        }
    }
}
