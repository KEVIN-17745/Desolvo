namespace DataAccess.Models
{
    public class DeveloperSkill
    {
        public int Id { get; set; }

        public int IdDeveloper { get; set; }

        public int IdSkill { get; set; }

        public Developer Developer { get; set; }

        public Skill Skill { get; set; }
    }
}
