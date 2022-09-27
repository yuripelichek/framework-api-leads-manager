using AutoMapper;
using Framework.LeadsManager.Application.Dtos;
using Framework.LeadsManager.Application.Interfaces;
using Framework.LeadsManager.Domain.Interfaces.Services;
using Framework.LeadsManager.Infrastructure.Components.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Framework.LeadsManager.Application.Services
{
    public class LeadAppService : ILeadAppService
    {
        private readonly ILeadService _leadService;
        private readonly IMapper _mapper;
        public LeadAppService(ILeadService leadService,
                              IMapper mapper)
        {
            _leadService = leadService;
            _mapper = mapper;
        }
        public async Task AcceptLeadAsync(int id)
        {
            var lead = await _leadService.GetById(id);

            if (lead == null)
                throw new Exception("Não foi possível encontrar o Lead");

            await _leadService.AcceptLeadAsync(lead);

            MailSender.SendMail("Lead aceito.");
        }
        public async Task DeclineLeadAsync(int id)
        {
            var lead = await _leadService.GetById(id);

            if (lead == null)
                throw new Exception("Não foi possível encontrar o Lead");

            await _leadService.DeclineLeadAsync(lead);
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
