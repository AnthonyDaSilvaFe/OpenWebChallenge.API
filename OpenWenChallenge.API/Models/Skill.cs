using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenWebChallenge.API.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Range(0, 100)]
        public int ExpertiseLevel { get; set; }

        [InverseProperty(nameof(ContactSkill.Skill))]
        public virtual ICollection<ContactSkill> ContactSkills { get; set; }
    }
}
