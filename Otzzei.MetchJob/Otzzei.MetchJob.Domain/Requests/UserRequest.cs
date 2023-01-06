using System.ComponentModel.DataAnnotations;

namespace Otzzei.MetchJob.Domain.Requests
{
    public class UserRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
