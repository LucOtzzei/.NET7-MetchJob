using Otzzei.MetchJob.Domain.Requests;

namespace Otzzei.MetchJob.Domain.Entities
{
    public class JobOpportunity
    {
        public JobOpportunity() { }
        public JobOpportunity(Guid managerJobId, JobOpportunityRequest request)
        {
            Id = Guid.NewGuid();
            ManagerJobId = managerJobId;
            JobTitle = request.JobTitle;
            SalaryCurrency = request.SalaryCurrency;
            MinimumWageAtWork = request.MinimumWageAtWork;
            MaximumWageAtWork = request.MaximumWageAtWork;
            JobsDescription = request.JobsDescription;
            JobActivities = request.JobActivities;
        }
        public Guid Id { get; set; }
        public Guid ManagerJobId { get; set; }
        public string JobTitle { get; set; }
        public CurrencyEnum SalaryCurrency { get; set; }
        public double MinimumWageAtWork { get; set; }
        public double MaximumWageAtWork { get; set; }
        public string JobsDescription { get; set; }
        public string JobActivities { get; set; }
    }
}
