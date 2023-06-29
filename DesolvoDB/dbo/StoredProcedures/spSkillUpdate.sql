CREATE PROCEDURE [dbo].[spSkillUpdate]
	@Id int,
	@Name NVARCHAR(50)
AS

begin
	UPDATE [dbo].[skill]
	SET Name=@Name
	WHERE Id=@Id;

end