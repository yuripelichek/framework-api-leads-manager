using Framework.LeadsManager.Application.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Framework.LeadsManager.Application.Interfaces
{
    public interface ILeadAppService : IServiceApp<LeadDto>
    {
        Task<IEnumerable<LeadInvitationDto>> GetAllInvitedLeadsAsync();
        Task<IEnumerable<LeadAcceptedDto>> GetAllAcceptedLeadsAsync();
        Task AcceptLeadAsync(int id);
        Task DeclineLeadAsync(int id);
    }
}
