namespace MyResume.Models
{
    public class Experience : BaseEntity
    {
        public string CompanyName { get; private set; } = string.Empty;
        public string Role { get; private set; } = string.Empty;
        public DateTime BeginDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public string Location { get; private set; } = string.Empty;
        public string Summary { get; private set; } = string.Empty;
        public bool CurrentJob { get; private set; }

        public Experience(string companyName, string role, DateTime begin, DateTime end, string location, string summary, bool currentJob)
        {
            CompanyName = companyName;
            Role = role;
            BeginDate = begin;
            Location = location;
            Summary = summary;
            CurrentJob = currentJob;
            EndDate = end;
        }

        public Experience(string companyName, string role, DateTime begin, string location, string summary, bool currentJob)
        {
            CompanyName = companyName;
            Role = role;
            BeginDate = begin;
            Location = location;
            Summary = summary;
            CurrentJob = currentJob;
        }

        public void ChangeCompanyName(string companyName)
        {
            CompanyName = companyName;
        }

        public void ChangeRole(string role)
        {
            Role = role;
        }

        public void ChangeBeginDate(DateTime date)
        {
            BeginDate = date;
        }

        public void ChangeEndDate(DateTime date)
        {
            EndDate = date;
        }

        public void ChangeLocation(string location)
        {
            Location = location;
        }

        public void ChangeSummary(string summary) 
        {
            Summary = summary;
        }

        public void EndCurrentJob(bool current, DateTime date)
        {
            CurrentJob = current;
            EndDate = date;
        }
    }
}