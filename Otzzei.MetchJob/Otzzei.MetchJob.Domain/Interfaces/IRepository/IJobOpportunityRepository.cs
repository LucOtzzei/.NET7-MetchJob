using Otzzei.MetchJob.Domain.Entities;

namespace Otzzei.MetchJob.Domain.Interfaces.IRepository
{
    public interface IJobOpportunityRepository
    {
        Task CreateJobOpportunityAsync(JobOpportunity job);
    }
}
