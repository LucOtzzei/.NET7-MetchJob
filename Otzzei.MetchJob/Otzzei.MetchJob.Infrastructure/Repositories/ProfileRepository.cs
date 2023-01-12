using Microsoft.EntityFrameworkCore;
using Otzzei.MetchJob.Domain.Entities;
using Otzzei.MetchJob.Domain.Interfaces.IRepository;
using Otzzei.MetchJob.Infrastructure.Context;

namespace Otzzei.MetchJob.Infrastructure.Repositories
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly MetchJobContext _context;
        public ProfileRepository(MetchJobContext context)
        {
            _context = context;
        }
        public async Task CreateProfileAsync(Profile profile)
        {
            _context.Profiles.Add(profile);
            await _context.SaveChangesAsync();
        }
        public async Task<Profile> GetProfileAsync(Guid profileId)
        {
            return await _context.Profiles.FirstOrDefaultAsync(x => x.Id == profileId);
        }
        public async Task UpdateProfileAsync(Profile profile)
        {
            _context.Profiles.Update(profile);
            await _context.SaveChangesAsync();
        }
    }
}
