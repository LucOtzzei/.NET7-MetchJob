using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> RequestPasswordRecoveryAsync(PasswordRecoveryRequest request)
        {
            var response = await _loginService.RequestPasswordRecoveryAsync(request);
            return Ok(response);
        }
        [HttpGet("change-password")]
        public async Task<IActionResult> RecoverPasswordAsync(ChangePasswordRequest request)
        {
            var response = await _loginService.RecoverPasswordAsync(request);
            return Ok(response);
        }
    }
}
