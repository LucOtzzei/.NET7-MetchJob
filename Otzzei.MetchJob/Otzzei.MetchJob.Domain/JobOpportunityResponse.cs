using Otzzei.MetchJob.Domain.Entities;

namespace Otzzei.MetchJob.Domain
{
    public class JobOpportunityResponse
    {
        public JobOpportunityResponse(JobOpportunity jobOpportunity)
        {
            JobTitle = jobOpportunity.JobTitle;
            CompanyName = jobOpportunity.CompanyName;
            SalaryCurrency = jobOpportunity.SalaryCurrency;
            MinimumWageAtWork = jobOpportunity.MinimumWageAtWork;
            MaximumWageAtWork = jobOpportunity.MaximumWageAtWork;
            JobsDescription = jobOpportunity.JobsDescription;
            JobActivities = jobOpportunity.JobActivities;

        }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public CurrencyEnum SalaryCurrency { get; set; }
        public double MinimumWageAtWork { get; set; }
        public double MaximumWageAtWork { get; set; }
        public string JobsDescription { get; set; }
        public string JobActivities { get; set; }
    }
}
