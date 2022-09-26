using Framework.LeadsManager.Application.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Framework.LeadsManager.Application.Interfaces
{
    public interface ILeadAppService 
    {
        Task<IEnumerable<LeadInvitationDto>> GetAllInvitedLeadsAsync();
        Task<IEnumerable<LeadAcceptedDto>> GetAllAcceptedLeadsAsync();
        Task<IEnumerable<LeadDto>> GetAllAsync();
        Task AcceptLeadAsync(int id);
        Task DeclineLeadAsync(int id);
    }
}
