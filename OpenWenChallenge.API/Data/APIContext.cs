using Microsoft.EntityFrameworkCore;
using OpenWebChallenge.API.Models;

namespace OpenWebChallenge.API.Data
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions<APIContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<ContactSkill> ContactSkills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().ToTable("Contacts");
            modelBuilder.Entity<Skill>().ToTable("Skills");
            modelBuilder.Entity<ContactSkill>().ToTable("ContactSkills");
        }
    }
}
