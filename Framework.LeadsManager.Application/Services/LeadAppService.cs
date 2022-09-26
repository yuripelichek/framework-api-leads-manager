using Framework.LeadsManager.Application.Dtos;
using Framework.LeadsManager.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.LeadsManager.Application.Services
{
    public class LeadAppService : ILeadAppService
    {
        public Task AcceptLeadAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(LeadDto item)
        {
            throw new NotImplementedException();
        }

        public Task DeclineLeadAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LeadAcceptedDto>> GetAllAcceptedLeadsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LeadDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LeadInvitationDto>> GetAllInvitedLeadsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<LeadDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(LeadDto item)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(LeadDto item)
        {
            throw new NotImplementedException();
        }
    }
}
