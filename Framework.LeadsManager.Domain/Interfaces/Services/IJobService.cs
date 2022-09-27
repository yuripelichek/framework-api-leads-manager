using Framework.LeadsManager.Domain.Entities;
using System.Threading.Tasks;

namespace Framework.LeadsManager.Domain.Interfaces.Services
{
    public interface IJobService : IService<Job> 
    {
        Task<Job> ApplyRuleOfDiscount(Job job, bool isApproved);
    }
}
