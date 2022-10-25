namespace MyResume.Models
{
    public class Experience : BaseEntity
    {
        public string CompanyName { get; private set; } = string.Empty;
        public string Role { get; private set; } = string.Empty;
        public DateTime Begin { get; private set; }
        public DateTime End { get; private set; }
        public string Location { get; private set; } = string.Empty;
        public string Summary { get; private set; } = string.Empty;
    }
}