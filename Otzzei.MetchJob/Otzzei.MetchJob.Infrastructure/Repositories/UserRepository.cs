using Otzzei.MetchJob.Domain.Entities;
using Otzzei.MetchJob.Domain.Interfaces.IRepository;
using Otzzei.MetchJob.Infrastructure.Context;

namespace Otzzei.MetchJob.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MetchJobContext _context;
        public UserRepository(MetchJobContext context)
        {
            _context = context;
        }
        public void CreateUserProfile(UserProfile profile)
        {
            _context.UserProfiles.Add(profile);
        }
    }
}
