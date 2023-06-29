using DataAccess.Models;

namespace DataAccess.Data
{
    public interface ISkillData
    {
        Task CreateSkill(Skill skill);
        Task DeleteSkill(int id);
        Task<Skill?> GetSkill(int id);
        Task UpdateSkill(Skill skill);
    }
}