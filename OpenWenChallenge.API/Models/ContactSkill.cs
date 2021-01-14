namespace OpenWebChallenge.API.Models
{
    public class ContactSkill
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public int SkillId { get; set; }

        public Contact Contact { get; set; }
        public Skill Skill { get; set; }
    }
}
