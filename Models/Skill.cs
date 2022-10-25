namespace MyResume.Models
{
    public class Skill : BaseEntity
    {
        public string Name { get; private set; } = string.Empty;
        public ExpertiseLevel ExpertiseLevel { get; private set; }

        public Skill(string name, ExpertiseLevel expertiseLevel)
        {
            Name = name;
            ExpertiseLevel = expertiseLevel;
        }

        public void ChangeSkillName(string name)
        {
            Name = name;
        }

        public void ChangeExpertiseLevel(ExpertiseLevel expertiseLevel)
        {
            ExpertiseLevel = ExpertiseLevel;
        }
    }
}
