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
        [Route("getAllInvitedLeads")]
        public async Task<ActionResult<IEnumerable<LeadInvitationDto>>> GetAllInvitedLeads()
        {
            var leads = await _leadAppService.GetAllInvitedLeadsAsync();
            return Ok(leads);
        }

        [HttpGet]
        [Route("getAllAcceptedLeads")]
        public async Task<ActionResult<IEnumerable<LeadAcceptedDto>>> GetAllAcceptedLeads()
        {
            var leads = await _leadAppService.GetAllAcceptedLeadsAsync();
            return Ok(leads);
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<ActionResult<IEnumerable<LeadDto>>> Get()
        {
            var leads = await _leadAppService.GetAllAsync();
            return Ok(leads);
        }
    }
}
