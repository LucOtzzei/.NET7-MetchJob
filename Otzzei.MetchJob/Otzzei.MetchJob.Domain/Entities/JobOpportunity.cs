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
            CompanyName = request.CompanyName;
            JobTitle = request.JobTitle;
            SalaryCurrency = request.SalaryCurrency;
            MinimumWageAtWork = request.MinimumWageAtWork;
            MaximumWageAtWork = request.MaximumWageAtWork;
            JobsDescription = request.JobsDescription;
            JobActivities = request.JobActivities;
            VacanciesFilled = false;
        }
        public Guid Id { get; set; }
        public Guid ManagerJobId { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public CurrencyEnum SalaryCurrency { get; set; }
        public double MinimumWageAtWork { get; set; }
        public double MaximumWageAtWork { get; set; }
        public string JobsDescription { get; set; }
        public string JobActivities { get; set; }
        public bool VacanciesFilled { get; set; }

        public void Update(JobOpportunityRequest request)
        {
            CompanyName = request.CompanyName;
            JobTitle = request.JobTitle;
            SalaryCurrency = request.SalaryCurrency;
            MinimumWageAtWork = request.MinimumWageAtWork;
            MaximumWageAtWork = request.MaximumWageAtWork;
            JobsDescription = request.JobsDescription;
            JobActivities = request.JobActivities;
        }
        public void MarkCacancyAsFilled() => VacanciesFilled = true;
        public void MarkCacancyAsOpen() => VacanciesFilled = false;
    }
}
