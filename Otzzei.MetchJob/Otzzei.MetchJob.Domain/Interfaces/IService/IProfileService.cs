using Otzzei.MetchJob.Domain.Requests;
using Otzzei.MetchJob.Domain.Responses;

namespace Otzzei.MetchJob.Domain.Interfaces.IService
{
    public interface IProfileService
    {
        Task<Guid> CreateProfileAsync(ProfileRequest request);
        Task<Guid> UpdateProfileAsync(Guid profileId, ProfileRequest request);
        Task<ProfileResponse> GetProfileAsync(Guid profileId);
    }
}
