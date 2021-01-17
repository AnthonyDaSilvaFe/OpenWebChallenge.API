using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenWebChallenge.API.Models
{
    public class ContactSkill
    {
        [Key]
        public int Id { get; set; }

        public int ContactId { get; set; }

        public int SkillId { get; set; }

        [ForeignKey(nameof(ContactId))]
        [InverseProperty(nameof(ContactSkill.Contact.ContactSkills))]
        public Contact Contact { get; set; }

        [ForeignKey(nameof(SkillId))]
        [InverseProperty(nameof(ContactSkill.Contact.ContactSkills))]
        public Skill Skill { get; set; }
    }
}
