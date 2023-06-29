CREATE PROCEDURE [dbo].[spDeveloperDelete]
	@Id int
	
AS
begin

	DELETE 
	FROM [dbo].[Developer]
	WHERE Id=@Id;
end

