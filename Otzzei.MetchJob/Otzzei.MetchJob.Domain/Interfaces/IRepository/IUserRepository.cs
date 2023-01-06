using Otzzei.MetchJob.Domain.Entities;

namespace Otzzei.MetchJob.Domain.Interfaces.IRepository
{
    public interface IUserRepository
    {
        void CreateUserProfile(UserProfile profile);
    }
}
