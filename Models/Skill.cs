namespace MyResume.Models
{
    public class Skill : BaseEntity
    {
        public string Name { get; private set; } = string.Empty;
        public ExpertiseLevel ExpertiseLevel { get; private set; }
    }
}
