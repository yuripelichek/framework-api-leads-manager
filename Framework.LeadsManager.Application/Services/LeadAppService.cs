using AutoMapper;
using Framework.LeadsManager.Application.Dtos;
using Framework.LeadsManager.Application.Interfaces;
using Framework.LeadsManager.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Framework.LeadsManager.Application.Services
{
    public class LeadAppService : ILeadAppService
    {
        private readonly ILeadService _leadService;
        private readonly IMapper _mapper;
        public LeadAppService(ILeadService leadService,
                              IMapper mapper) { 
            _leadService = leadService;
            _mapper = mapper;
        }
        public async Task AcceptLeadAsync(int id)
        {
            await _leadService.RemoveAsync(id);
        }
        public Task DeclineLeadAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<LeadAcceptedDto>> GetAllAcceptedLeadsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<LeadDto>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<LeadDto>>(await _leadService.GetAllAsync());
        }

        public Task<IEnumerable<LeadInvitationDto>> GetAllInvitedLeadsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
