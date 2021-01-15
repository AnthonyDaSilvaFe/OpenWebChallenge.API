using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OpenWebChallenge.API.Models
{
    public class Skill
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [Range(0, 100)]
        public int ExpertiseLevel { get; set; }

        public ICollection<ContactSkill> ContactSkills { get; set; }
    }
}
