using Microsoft.AspNetCore.Mvc;
using Otzzei.MetchJob.Domain.Interfaces.IService;
using Otzzei.MetchJob.Domain.Requests;

namespace Otzzei.MetchJob.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateUserAsync(UserRequest request)
        {
            var response = await _userService.CreateUserAsync(request);
            return Ok(response);
        }
        [HttpPost("profile")]
        public async Task<IActionResult> CreateUserProfile(UserProfileRequest request)
        {
            var response = await _userService.CreateUserProfileAsync(request);
            return Ok(response);
        }
    }
}
