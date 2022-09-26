using Framework.LeadsManager.Domain.Entities;
using Framework.LeadsManager.Domain.Interfaces;
using Framework.LeadsManager.Domain.Interfaces.Services;

namespace Framework.LeadsManager.Domain.Services
{
    public class JobService : Service<Job>, IJobService
    {
        private readonly IJobRepository Repository;

        public JobService(IJobRepository repository) : base(repository) => Repository = repository;
    }
}
