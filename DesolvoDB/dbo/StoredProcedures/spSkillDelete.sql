CREATE PROCEDURE [dbo].[spSkillDelete]
	@Id int

AS
begin

	DELETE FROM [dbo].[Skill]
	WHERE Id =@Id
end
