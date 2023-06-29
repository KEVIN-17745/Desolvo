CREATE PROCEDURE [dbo].[spSkillCreate]
	@Name nvarchar(50)
AS
begin
	INSERT INTO [dbo].[Skill] (Name)
	VALUES (@Name)

end


