using Otzzei.MetchJob.Domain.Entities;
using Otzzei.MetchJob.Domain.Interfaces.IRepository;
using Otzzei.MetchJob.Domain.Interfaces.IService;
using Otzzei.MetchJob.Domain.Requests;
using Otzzei.MetchJob.Domain.Responses;

namespace Otzzei.MetchJob.Domain.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IProfileRepository _profileRepository;
        public ProfileService(IProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
        }
        public async Task<Guid> CreateProfileAsync(ProfileRequest request)
        {
            var profile = new Profile(request);
            await _profileRepository.CreateProfileAsync(profile);
            return profile.Id;
        }
        public async Task<ProfileResponse> GetProfileAsync(Guid profileId)
        {
            var profile = await _profileRepository.GetProfileAsync(profileId);
            return new ProfileResponse(profile);
        }
        public async Task<Guid> UpdateProfileAsync(Guid profileId, ProfileRequest request)
        {
            var profile = await _profileRepository.GetProfileAsync(profileId);
            profile.Update(request);
            await _profileRepository.UpdateProfileAsync(profile);
            return profile.Id;
        }
    }
}
