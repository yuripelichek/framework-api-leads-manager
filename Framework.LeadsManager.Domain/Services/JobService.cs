using Framework.LeadsManager.Domain.Entities;
using Framework.LeadsManager.Domain.Interfaces;
using Framework.LeadsManager.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace Framework.LeadsManager.Domain.Services
{
    public class JobService : Service<Job>, IJobService
    {
        private readonly IJobRepository Repository;
        public JobService(IJobRepository repository) : base(repository) => Repository = repository;

        public Task<Job> ApplyRuleOfDiscount(Job job, bool isApproved)
        {
            throw new System.NotImplementedException();
        }
    }
}
