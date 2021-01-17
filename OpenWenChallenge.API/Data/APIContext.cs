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

            modelBuilder.Entity<ContactSkill>(entity =>
            {
                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ContactSkills)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactSkill_Contact");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.ContactSkills)
                    .HasForeignKey(d => d.SkillId)
                    .HasConstraintName("FK_ContactSkill_Skill");
            });
        }
    }
}
