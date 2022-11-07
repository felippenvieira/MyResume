namespace MyResume.Models
{
    public class Me : BaseEntity
    {
        public string Name { get; private set; } = string.Empty;
        public string Role { get; private set; } = string.Empty;
        public string Summary { get; private set; } = string.Empty;
        public Contact Contact { get; private set; }
        public List<Experience> Experiences { get; private set; }
        public List<Skill> Skills { get; private set; }
        public List<Certification> Certifications { get; private set; }

        public Me(string name, string role, string summary, Contact contact, List<Experience> experiences, List<Skill> skills, List<Certification> certifications)
        {
            Name = name;
            Role = role;
            Summary = summary;
            Contact = contact;
            Experiences = experiences;
            Skills = skills;
            Certifications = certifications;
        }

        public void UpdateName(string name)
        {
            Name = name;
        }

        public void UpdateRole(string role)
        {
            Role = role;
        }

        public void UpdateSummary(string summary)
        {
            Summary = summary;
        }
    }
}
