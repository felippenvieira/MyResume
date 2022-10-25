namespace MyResume.Models
{
    public class Certification : BaseEntity
    {
        public string Name { get; private set; } = string.Empty;
        public string Company { get; private set; } = string.Empty;

        public Certification(string name, string company)
        {
            Name = name;
            Company = company;
        }

        public void ChangeCertificationName(string name)
        {
            Name = name;
        }

        public void ChangeCompanyName(string name)
        {
            Company = name;
        }
    }
}