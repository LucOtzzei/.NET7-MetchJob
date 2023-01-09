using Microsoft.AspNetCore.Mvc;
using Otzzei.MetchJob.Domain.Interfaces.IService;
using Otzzei.MetchJob.Domain.Requests;

namespace Otzzei.MetchJob.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobOpportunityController : ControllerBase
    {
        private readonly IJobOpportunityService _jobOpportunityService;
        public JobOpportunityController(IJobOpportunityService jobOpportunityService)
        {
            _jobOpportunityService = jobOpportunityService;
        }
        [HttpPost("{jobAdminId}")]
        public async Task<IActionResult> CreateJobOpportunityAsync([FromRoute] Guid jobAdminId, [FromBody] JobOpportunityRequest request)
        {
            var response = await _jobOpportunityService.CreateJobOpportunityAsync(jobAdminId, request);
            return Ok(response);
        }
        [HttpPut("{jobOpportunityId}")]
        public async Task<IActionResult> UpdateJobOpportunityAsync([FromRoute] Guid jobOpportunityId, [FromBody] JobOpportunityRequest request)
        {
            var response = await _jobOpportunityService.UpdateJobOpportunityAsync(jobOpportunityId, request);
            return Ok(response);
        }
    }
}
