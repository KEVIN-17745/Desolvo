CREATE PROCEDURE [dbo].[spDeveloperInsert]
	@Name NVARCHAR(50) ,
	@Surename NVARCHAR(50)

	
AS

begin
	INSERT into dbo.[Developer] (Name, Surename)
	VALUES (@Name, @Surename);

end
