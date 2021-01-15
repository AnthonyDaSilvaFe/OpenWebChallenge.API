using System.ComponentModel.DataAnnotations;

namespace OpenWebChallenge.API.Models
{
    public class ContactSkill
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int ContactId { get; set; }
        [Required]
        public int SkillId { get; set; }

        public Contact Contact { get; set; }
        public Skill Skill { get; set; }
    }
}
