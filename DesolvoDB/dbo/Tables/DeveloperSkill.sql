CREATE TABLE [dbo].[DeveloperSkill]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [IdDeveloper] INT NOT NULL, 
    [IdSkill] INT NOT NULL,
    FOREIGN KEY (IdDeveloper) REFERENCES Developer(Id),
    FOREIGN KEY (IdSkill) REFERENCES Skill(Id)
)
