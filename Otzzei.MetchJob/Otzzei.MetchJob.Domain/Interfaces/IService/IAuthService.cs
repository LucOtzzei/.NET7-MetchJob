using Microsoft.AspNetCore.Identity;
using Otzzei.MetchJob.Domain.Requests;

namespace Otzzei.MetchJob.Domain.Interfaces.IService
{
    public interface IAuthService
    {
        Task<SignInResult> LoginAsync(LoginRequest request);
        Task<Guid> PasswordRecoveryRequestAsync(RecoveryPasswordRequest request);
        Task<Guid> RecoverPasswordAsync(RecoverPasswordRequest request);
        Task<Guid> ChangePasswordAsync(ChangePasswordRequest request);

    }
}
