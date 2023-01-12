using Otzzei.MetchJob.Domain.Entities;

namespace Otzzei.MetchJob.Domain.Interfaces.IRepository
{
    public interface IProfileRepository
    {
        Task CreateProfileAsync(Profile profile);
        Task UpdateProfileAsync(Profile profile);
        Task<Profile> GetProfileAsync(Guid profileId);
    }
}
