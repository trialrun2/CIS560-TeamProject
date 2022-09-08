If not exists 
	(
		Select * 
		From sys.schemas s
		Where s.[name] = N'School'
	)
Begin
	Exec(N'Create Schema [School] Authorization [dbo]');
End;