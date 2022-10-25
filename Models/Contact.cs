namespace MyResume.Models
{
    public class Contact : BaseEntity
    {
        public string Phone { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public List<string> SocialMedia { get; private set; }
    }
}