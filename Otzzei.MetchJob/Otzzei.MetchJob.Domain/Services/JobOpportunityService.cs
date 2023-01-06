using Otzzei.MetchJob.Domain.Entities;
using Otzzei.MetchJob.Domain.Interfaces.IRepository;
using Otzzei.MetchJob.Domain.Interfaces.IService;
using Otzzei.MetchJob.Domain.Requests;

namespace Otzzei.MetchJob.Domain.Services
{
    public class JobOpportunityService : IJobOpportunityService
    {
        private readonly IJobOpportunityRepository _jobOpportunityRepository;
        public JobOpportunityService(IJobOpportunityRepository jobOpportunityRepository)
        {
            _jobOpportunityRepository = jobOpportunityRepository;
        }
        public async Task<Guid> CreateJobOpportunityAsync(Guid managerJobId, JobOpportunityRequest request)
        {
            var job = new JobOpportunity(managerJobId, request);
            await _jobOpportunityRepository.CreateJobOpportunityAsync(job);

            return job.Id;
        }
    }
}
