using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Otzzei.MetchJob.Domain.Requests;

namespace Otzzei.MetchJob.Domain.Services
{
    public class AuthService
    {
        private readonly SignInManager<IdentityUser<Guid>> _signInManager;
        public AuthService(SignInManager<IdentityUser<Guid>> signInManager)
        {
            _signInManager = signInManager;
        }


        public async Task<SignInResult> LoginAsync(LoginRequest request)
        {
            var user = await GetUserByEmailAsync(request.Email);
            var login = _signInManager.PasswordSignInAsync(user.UserName, request.Password, false, false);
            return login.Result;
        }
        public async Task PasswordRecoveryRequestAsync(RecoveryPasswordRequest request)
        {
            var user = await GetUserByEmailAsync(request.Email);
            var recoveryToken = await _signInManager.UserManager.GeneratePasswordResetTokenAsync(user);
        }
        public async Task RecoverPasswordAsync(RecoverPasswordRequest request)
        {
            var user = await GetUserByEmailAsync(request.Email);
            await _signInManager.UserManager.ResetPasswordAsync(user, request.Token, request.NewPassword);
        }
        public async Task ChangePasswordAsync(ChangePasswordRequest request)
        {
            var user = await GetUserByEmailAsync(request.Email);
            await _signInManager.UserManager.ChangePasswordAsync(user, request.Password, request.NewPassword);
        }
        private async Task<IdentityUser<Guid>> GetUserByEmailAsync(string email)
        {
            var user = await _signInManager.UserManager.Users.FirstOrDefaultAsync(x => x.Email == email);
            return user;
        }
    }
}
