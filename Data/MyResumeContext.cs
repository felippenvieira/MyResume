using Microsoft.EntityFrameworkCore;
using MyResume.Models;

namespace MyResume.Data
{
    public class MyResumeContext : DbContext
    {
        public MyResumeContext(DbContextOptions<MyResumeContext> options) : base(options) { }

        public DbSet<Certification> Certifications { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Me> Me { get; set; }
    }
}
