using DataAccess.Models;
using DataAccess.DbAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;

public class SkillData : ISkillData
{
    private readonly ISqlDataAccess _db;
    public SkillData(ISqlDataAccess db)
    {
        _db = db;
    }

    public async Task<Skill?> GetSkill(int id)
    {
        var results = await _db.LoadData<Skill, dynamic>(
            "dbo.spSkillGet",
            new { Id = id });
        return results.FirstOrDefault();
    }


    public Task CreateSkill(Skill skill) =>
        _db.SaveData("dbo.spSkillCreate", new { skill.Name });

    public Task UpdateSkill(Skill skill) =>
        _db.SaveData("dbo.spSkillUpdate", skill);

    public Task DeleteSkill(int id) =>
        _db.SaveData("dbo.spSkillDelete", new { Id = id });
}

