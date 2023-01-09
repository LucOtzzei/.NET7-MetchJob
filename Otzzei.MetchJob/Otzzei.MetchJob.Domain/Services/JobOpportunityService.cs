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
        public async Task<Guid> CreateJobOpportunityAsync(Guid jobAdminId, JobOpportunityRequest request)
        {
            var job = new JobOpportunity(jobAdminId, request);
            await _jobOpportunityRepository.CreateJobOpportunityAsync(job);

            return job.Id;
        }

        public async Task<JobOpportunityResponse> GetJobOpportunityAsync(Guid jobOpportunityId)
        {
            var job = await _jobOpportunityRepository.GetJobOpportunityAsync(jobOpportunityId);
            var jobResponse = new JobOpportunityResponse(job);
            return jobResponse;
        }

        public async Task<Guid> UpdateJobOpportunityAsync(Guid jobOpportunituId, JobOpportunityRequest request)
        {
            var job = await _jobOpportunityRepository.GetJobOpportunityAsync(jobOpportunituId);
            job.Update(request);

            await _jobOpportunityRepository.UpdateJobOpportunityAsync(job);

            return job.Id;
        }
    }
}
