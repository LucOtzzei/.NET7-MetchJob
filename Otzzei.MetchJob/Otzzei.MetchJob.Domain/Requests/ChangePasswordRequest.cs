using System.ComponentModel.DataAnnotations;

namespace Otzzei.MetchJob.Domain.Requests
{
    public class ChangePasswordRequest
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string NewPassword { get; set; }
    }
}
