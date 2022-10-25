namespace MyResume.Models
{
    public class Certification : BaseEntity
    {
        public string Name { get; private set; } = string.Empty;
        public string Company { get; private set; } = string.Empty;
    }
}