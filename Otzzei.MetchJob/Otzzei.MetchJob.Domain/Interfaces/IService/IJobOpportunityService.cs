using Otzzei.MetchJob.Domain.Requests;

namespace Otzzei.MetchJob.Domain.Interfaces.IService
{
    public interface IJobOpportunityService
    {
        Task<Guid> CreateJobOpportunityAsync(Guid jobAdminId, JobOpportunityRequest request);
        Task<Guid> UpdateJobOpportunityAsync(Guid jobOpportunituId, JobOpportunityRequest request);
        Task<JobOpportunityResponse> GetJobOpportunityAsync(Guid jobOpportunityId);
        Task<List<JobOpportunityResponse>> GetAllJobOpportunitiesAsync();
        Task<Guid> DeleteJobOpportunityAsync(Guid jobOpportunityId);
        Task<Guid> MarkCacancyAsFilledAsync(Guid jobOpportunityId);
        Task<Guid> MarkCacancyAsOpenAsync(Guid jobOpportunityId);
    }
}
