if not exists (select 1 from dbo.[Developer])
begin
	insert into dbo.[Developer] (Name, Surename)
	values('kevin', 'dalpathadu'),
		  ('laura', 'fernandez');
	insert into dbo.[Skill] (Name)
	values('Database and data mining'),
		  ('C# Programming and java')
end