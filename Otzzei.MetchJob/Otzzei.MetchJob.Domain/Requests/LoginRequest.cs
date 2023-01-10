using System.ComponentModel.DataAnnotations;

namespace Otzzei.MetchJob.Domain.Requests
{
    public class LoginRequest
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
