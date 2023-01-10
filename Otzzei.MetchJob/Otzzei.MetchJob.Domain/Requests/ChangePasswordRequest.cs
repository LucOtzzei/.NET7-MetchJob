using System.ComponentModel.DataAnnotations;

namespace Otzzei.MetchJob.Domain.Requests
{
    public class ChangePasswordRequest
    {
        [Required]
        public Token Token { get; set; }
        [Required]
        public string NewPassword { get; set; }
    }
}
