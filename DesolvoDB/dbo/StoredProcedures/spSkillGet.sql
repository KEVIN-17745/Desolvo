CREATE PROCEDURE [dbo].[spSkillGet]
	@id int
AS
begin

	SELECT *
	FROM [dbo].[Skill]
	WHERE id=@Id

end
