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
        [HttpGet("{jobOpportunityId}")]
        public async Task<IActionResult> GetJobOpportunityAsync([FromRoute] Guid jobOpportunityId)
        {
            var response = await _jobOpportunityService.GetJobOpportunityAsync(jobOpportunityId);
            return Ok(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllJobOpportunitiesAsync()
        {
            var response = await _jobOpportunityService.GetAllJobOpportunitiesAsync();
            return Ok(response);
        }
        [HttpDelete("{jobOpportunityId")]
        public async Task<IActionResult> DeleteJobOpportunityAsync([FromRoute] Guid jobOpportunityId)
        {
            var response = await _jobOpportunityService.DeleteJobOpportunityAsync(jobOpportunityId);
            return Ok(response);
        }
    }
}
