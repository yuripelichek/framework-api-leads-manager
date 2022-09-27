using Framework.LeadsManager.Application.Dtos;
using Framework.LeadsManager.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Framework.LeadsManager.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class LeadsController : ControllerBase
    {
        private readonly ILeadAppService _leadAppService;
        
        public LeadsController(ILeadAppService leadAppService)
        {
            _leadAppService = leadAppService;
        }

        [HttpGet]
        [Route("invitedLeads")]
        public async Task<ActionResult<IEnumerable<LeadInvitationDto>>> GetAllInvitedLeads()
        {
            var leads = await _leadAppService.GetAllInvitedLeadsAsync();
            return Ok(leads);
        }

        [HttpGet]
        [Route("acceptedLeads")]
        public async Task<ActionResult<IEnumerable<LeadAcceptedDto>>> GetAllAcceptedLeads()
        {
            var leads = await _leadAppService.GetAllAcceptedLeadsAsync();
            return Ok(leads);
        }

        [HttpPost]
        [Route("acceptLead")]
        public async Task<ActionResult<LeadDto>> AcceptLead([FromBody] LeadDefineDto lead)
        {
            await _leadAppService.AcceptLeadAsync(lead.idLead);
            return Ok("Lead aceito");
        }

        [HttpPost]
        [Route("declineLead")]
        public async Task<ActionResult<LeadDto>> DeclineLead([FromBody] LeadDefineDto lead)
        {
            await _leadAppService.DeclineLeadAsync(lead.idLead);
            return Ok("Lead declinado");
        }
    }
}
