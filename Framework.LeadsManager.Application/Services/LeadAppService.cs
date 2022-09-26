using AutoMapper;
using Framework.LeadsManager.Application.Dtos;
using Framework.LeadsManager.Application.Interfaces;
using Framework.LeadsManager.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Framework.LeadsManager.Application.Services
{
    public class LeadAppService : ILeadAppService
    {
        private readonly ILeadService _leadService;
        private readonly IJobService _jobService;
        private readonly IClientService _clientService;
        private readonly IMapper _mapper;
        public LeadAppService(ILeadService leadService,
            IClientService clientService,
                              IMapper mapper) { 
            _leadService = leadService;
            _mapper = mapper;
            _clientService = clientService;
        }
        public async Task AcceptLeadAsync(int id)
        {
            await _leadService.RemoveAsync(id);
        }
        public Task DeclineLeadAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<LeadAcceptedDto>> GetAllAcceptedLeadsAsync()
        {
            var retornoLead = await _leadService.GetAllAsync();
            retornoLead = retornoLead.Where(x => x.Approved is true);
            var retorno = _mapper.Map<IEnumerable<LeadAcceptedDto>>(retornoLead);

            return retorno;
        }

        public async Task<IEnumerable<LeadInvitationDto>> GetAllInvitedLeadsAsync()
        {
            var retornoLead = await _leadService.GetAllAsync();
            retornoLead = retornoLead.Where(x => x.Approved is null);
            var retorno = _mapper.Map<IEnumerable<LeadInvitationDto>>(retornoLead);

            return retorno;
        }
    }
}
