using Otzzei.MetchJob.Domain.Entities;

namespace Otzzei.MetchJob.Domain.Responses
{
    public class ProfileResponse
    {
        public ProfileResponse(Profile profile)
        {
            Id = profile.Id;
            FirstName = profile.FirstName;
            LastName = profile.LastName;
            AboutMe = profile.AboutMe;
        }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AboutMe { get; set; }
    }
}
