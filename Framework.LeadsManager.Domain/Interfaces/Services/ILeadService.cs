using Framework.LeadsManager.Domain.Entities;
using System.Threading.Tasks;

namespace Framework.LeadsManager.Domain.Interfaces.Services
{
    public interface ILeadService : IService<Lead> 
    {
        Task<Lead> AcceptLeadAsync(Lead lead);
        Task<Lead> DeclineLeadAsync(Lead lead);
    }
}
