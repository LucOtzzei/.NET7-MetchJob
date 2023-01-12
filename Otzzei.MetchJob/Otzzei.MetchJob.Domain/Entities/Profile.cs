using Otzzei.MetchJob.Domain.Requests;

namespace Otzzei.MetchJob.Domain.Entities
{
    public class Profile
    {
        public Profile() { }
        public Profile(ProfileRequest request)
        {
            Id = Guid.NewGuid();
            FirstName = request.FirstName;
            LastName = request.LastName;
            AboutMe = request.AboutMe;

        }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AboutMe { get; set; }

        public void Update(ProfileRequest request)
        {
            FirstName = request.FirstName;
            LastName = request.LastName;
            AboutMe = request.AboutMe;
        }
    }
}
