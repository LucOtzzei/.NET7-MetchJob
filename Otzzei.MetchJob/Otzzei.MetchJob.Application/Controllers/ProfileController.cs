using Microsoft.AspNetCore.Mvc;
using Otzzei.MetchJob.Domain.Interfaces.IService;
using Otzzei.MetchJob.Domain.Requests;

namespace Otzzei.MetchJob.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileService _profileService;
        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateProfileAsync(ProfileRequest request)
        {
            var response = await _profileService.CreateProfileAsync(request);
            return response;
        }
        [HttpPut("{profileId}")]
        public async Task<IActionResult> UpdateProfileAsync(Guid profile, ProfileRequest request)
        {
            var response = await _profileService.CreateProfileAsync(request);
            return response;
        }
        [HttpGet("{profileId}")]
        public async Task<IActionResult> GetProfileAsync(Guid profileId)
        {
            var response = await _profileService.CreateProfileAsync(profileId);
            return response;
        }
    }
}
