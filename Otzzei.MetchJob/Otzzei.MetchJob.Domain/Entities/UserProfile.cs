using Otzzei.MetchJob.Domain.Requests;

namespace Otzzei.MetchJob.Domain.Entities
{
    public class UserProfile
    {
        public UserProfile() { }
        public UserProfile(UserProfileRequest request)
        {
            Id = Guid.NewGuid();
            Name = request.Name;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
