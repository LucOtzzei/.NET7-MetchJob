using Microsoft.AspNetCore.Mvc;
using Otzzei.MetchJob.Domain.Interfaces.IService;
using Otzzei.MetchJob.Domain.Requests;

namespace Otzzei.MetchJob.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _loginService;

        public AuthController(IAuthService loginService)
        {
            _loginService = loginService;
        }
        [HttpPost]
        public async Task<IActionResult> LoginAsync(LoginRequest request)
        {
            var response = await _loginService.LoginAsync(request);
            return Ok(response);
        }
        [HttpGet("request-password-recovery")]
        public async Task<IActionResult> RequestPasswordRecoveryAsync(RecoveryPasswordRequest request)
        {
            var response = await _loginService.PasswordRecoveryRequestAsync(request);
            return Ok(response);
        }
        [HttpPost("recover-password")]
        public async Task<IActionResult> RecoverPasswordAsync(RecoverPasswordRequest request)
        {
            var response = await _loginService.RecoverPasswordAsync(request);
            return Ok(response);
        }
        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePasswordAsync(ChangePasswordRequest request)
        {
            var response = await _loginService.ChangePasswordAsync(request);
            return Ok(response);
        }
    }
}
