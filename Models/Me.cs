﻿namespace MyResume.Models
{
    public class Me : BaseEntity
    {
        public string Name { get; private set; } = string.Empty;
        public string Role { get; private set; } = string.Empty;
        public string Summary { get; private set; } = string.Empty;
        public Contact Contact { get; private set; }
        public List<Experience> Experiences { get; private set; }
        public List<Competence> Competences { get; private set; }
    }
}
