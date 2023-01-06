using Otzzei.MetchJob.Domain.Requests;

namespace Otzzei.MetchJob.Domain.Interfaces.IService
{
    public interface IJobOpportunityService
    {
        Task<Guid> CreateJobOpportunityAsync(Guid managerJobId, JobOpportunityRequest request);
    }
}
