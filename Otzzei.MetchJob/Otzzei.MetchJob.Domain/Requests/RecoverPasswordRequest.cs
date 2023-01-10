namespace Otzzei.MetchJob.Domain.Requests
{
    public class RecoverPasswordRequest
    {
        public string Token { get; set; }
        public string Email { get; set; }
        public string NewPassword { get; set; }
    }
}
