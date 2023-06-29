CREATE PROCEDURE [dbo].[spDeveloperGet]
	@Id int
	
AS
begin

	SELECT Id, Name, Surename 
	FROM [dbo].[Developer]
	WHERE Id=@Id;
end

