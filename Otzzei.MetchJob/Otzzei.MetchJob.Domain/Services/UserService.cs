using Microsoft.AspNetCore.Identity;
using Otzzei.MetchJob.Domain.Entities;
using Otzzei.MetchJob.Domain.Interfaces.IRepository;
using Otzzei.MetchJob.Domain.Interfaces.IService;
using Otzzei.MetchJob.Domain.Requests;

namespace Otzzei.MetchJob.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<IdentityUser<Guid>> _userManager;
        private readonly IUserRepository _userRepository;
        public UserService(UserManager<IdentityUser<Guid>> userManager)
        {
            _userManager = userManager;
        }
        public async Task<Guid> CreateUserAsync(UserRequest request)
        {
            var user = new IdentityUser<Guid>() { Email = request.Email, UserName = request.Email };
            var create = await _userManager.CreateAsync(user);
            var password = await _userManager.AddPasswordAsync(user, request.Password);

            return user.Id;
        }

        public async Task<Guid> CreateUserProfileAsync(UserProfileRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            var profile = new UserProfile(request);
            _userRepository.CreateUserProfile(profile);

            return profile.Id;
        }
    }
}
