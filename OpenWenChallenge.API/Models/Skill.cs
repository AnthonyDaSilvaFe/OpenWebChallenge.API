using System.Collections.Generic;

namespace OpenWebChallenge.API.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ExpertiseLevel { get; set; }

        public ICollection<ContactSkill> ContactSkills { get; set; }
    }
}
