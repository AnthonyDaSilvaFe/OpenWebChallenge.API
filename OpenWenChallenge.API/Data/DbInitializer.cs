
using OpenWebChallenge.API.Data;
using OpenWebChallenge.API.Models;
using System;
using System.Linq;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(APIContext context)
        {
            context.Database.EnsureCreated();

            // Look for any contacts.
            if (context.Contacts.Any())
            {
                return;   // DB has been seeded
            }

            var contacts = new Contact[]
            {
            new Contact{ FirstName = "Anthony", LastName = "Da Silva Ferreira", FullName = "Anthony Da Silva Ferreira", Address = "40 Chemin des Saules, 74330 Choisy", Email = "anthony.dasilva.ferreira@gmail.com", MobilePhoneNumber = "+33 7 85 27 04 80"  },
            new Contact{ FirstName = "Samus", LastName = "Samus Aran", FullName = "Samus Aran", Address = "Space", Email = "samus.aran@metroid.com", MobilePhoneNumber = "+66 1 23 45 76 90"  },
            new Contact{ FirstName = "Frodon", LastName = "Baggins", FullName = "Frodon Baggins", Address = "The Shire", Email = "frodon.baggins@shire.middleearth", MobilePhoneNumber = "+11 0 98 76 54 32"  },
            };

            foreach (var c in contacts)
            {
                context.Contacts.Add(c);
            }
            context.SaveChanges();

            // Look for any skills.
            if (context.Skills.Any())
            {
                return;   // DB has been seeded
            }

            var skills = new Skill[]
            {
                new Skill{ Name = ".Net Framework", ExpertiseLevel = 75},
                new Skill{ Name = "SQL", ExpertiseLevel = 80},
                new Skill{ Name = "Bounty Hunter", ExpertiseLevel = 100},
                new Skill{ Name = "Ring Bearer", ExpertiseLevel = 100}
            };

            foreach (var s in skills)
            {
                context.Skills.Add(s);
            }
            context.SaveChanges();

            // Look for any contact's skills.
            if (context.ContactSkills.Any())
            {
                return;   // DB has been seeded
            }

            var contactSkills = new ContactSkill[]
            {
                new ContactSkill{ ContactId = 1, SkillId = 1},
                new ContactSkill{ ContactId = 1, SkillId = 2},
                new ContactSkill{ ContactId = 2, SkillId = 3},
                new ContactSkill{ ContactId = 3, SkillId = 4},
            };

            foreach (var cs in contactSkills)
            {
                context.ContactSkills.Add(cs);
            }
            context.SaveChanges();
        }
    }
}