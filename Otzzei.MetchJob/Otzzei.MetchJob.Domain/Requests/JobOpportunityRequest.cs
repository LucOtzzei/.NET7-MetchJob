using Otzzei.MetchJob.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Otzzei.MetchJob.Domain.Requests
{
    public class JobOpportunityRequest
    {
        [Required]
        public string JobTitle { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public CurrencyEnum SalaryCurrency { get; set; }
        [Required]
        public double MinimumWageAtWork { get; set; }
        [Required]
        public double MaximumWageAtWork { get; set; }
        [Required]
        public string JobsDescription { get; set; }
        [Required]
        public string JobActivities { get; set; }
    }
}
