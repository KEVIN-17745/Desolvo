namespace Desolvo_TechnicalTest.Data.Models
{
    public class Developer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surename { get; set; }


        public ICollection<DeveloperSkill> DeveloperSkills { get; set; }
    }
}
