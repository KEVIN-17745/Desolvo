namespace Desolvo_API;
    public static class Api
    {

        public static void ConfigureApi(this WebApplication app) {

            app.MapGet("/Skills/{id}", GetSkill);
            app.MapPost("/Skills", CreateSkill);
        app.MapPut("/Skills", UpdateSkill);
        app.MapDelete("/Skills/{id}", DeleteSkill);

    }

        private static async Task<IResult> GetSkill(int id, ISkillData data)
        {
            try
            {
                var results = await data.GetSkill(id);
                if (results == null) return Results.NotFound();
                return Results.Ok(results); 
            }
            catch(Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    private static async Task<IResult> CreateSkill(Skill skill, ISkillData data)
    {
        try
        {
            await data.CreateSkill(skill);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateSkill(Skill skill, ISkillData data)
    {
        try
        {
            await data.UpdateSkill(skill);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteSkill(int id, ISkillData data)
    {
        try
        {
            await data.DeleteSkill(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}

