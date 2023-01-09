using Otzzei.MetchJob.Domain.Entities;
using Otzzei.MetchJob.Domain.Interfaces.IRepository;
using Otzzei.MetchJob.Infrastructure.Context;

namespace Otzzei.MetchJob.Infrastructure.Repositories
{
    public class JobOpportunityRepository : IJobOpportunityRepository
    {
        private readonly MetchJobContext _context;
        public JobOpportunityRepository(MetchJobContext context)
        {
            _context = context;
        }

        public async Task CreateJobOpportunityAsync(JobOpportunity job)
        {
            await _context.JobOpportunities.AddAsync(job);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateJobOpportunityAsync(JobOpportunity job)
        {
            _context.JobOpportunities.Update(job);
            await _context.SaveChangesAsync();
        }
    }
}
