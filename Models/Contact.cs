namespace MyResume.Models
{
    public class Contact : BaseEntity
    {
        public string Phone { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public List<string> SocialMedia { get; private set; }

        public Contact(string phone, string email, List<string> socialMedia)
        {
            Phone = phone;
            Email = email;
            SocialMedia = socialMedia;
        }

        public Contact(string email, List<string> socialMedia)
        {
            Email = email;
            SocialMedia = socialMedia;
        }

        public void UpdatePhone(string phone)
        {
            Phone = phone;
        }

        public void UpdateEmail(string email)
        {
            Email = email;
        }

        public void AddSocialMedia(string socialMedia)
        {
            SocialMedia.Add(socialMedia);
        }
    }
}