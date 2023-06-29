
/*
using DataAccess.Data.Models;
using DataAccess.DbAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;

    public class DeveloperData
    {
        private readonly ISqlDataAccess _db;
public DeveloperData(ISqlDataAccess db)
        {
            _db = db;
        }
    /*
        public Task<IEnumerable<Developer>> GetDevelopers() =>
               _db.LoadData<Developer, dynamic>("dbo.spDeveloperGetAll", new { });
   
    
    public Task InsertDeveloper(Developer developer) =>
        _db.SaveData("dbo.spDeveloperInsert", new { developer.Name, developer.Surename });

 
    */
/*
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

    public Task DeleteSkill(int id)=>
        _db.SaveData("dbo.spSkillDelete", new { Id =id});
}

*/