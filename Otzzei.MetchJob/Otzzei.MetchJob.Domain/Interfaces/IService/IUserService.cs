using Otzzei.MetchJob.Domain.Requests;

namespace Otzzei.MetchJob.Domain.Interfaces.IService
{
    public interface IUserService
    {
        Task<Guid> CreateUserAsync(UserRequest request);
        Task<Guid> CreateUserProfileAsync(UserRequest request);
    }
}
