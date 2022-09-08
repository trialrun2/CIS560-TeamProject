If OBJECT_ID(N'School.Semester') is null
Begin
	Create table School.Semester
	(
		SemesterId INT not null identity(1, 1),
		[Name] NVARCHAR(50) not null,
		StartDate DATETIMEOFFSET not null default(SYSDATETIMEOFFSET()),
		EndDate DATETIMEOFFSET not null default(SYSDATETIMEOFFSET())

		Constraint [PK_School_Semester_SemesterId] primary key clustered (SemesterId asc)
	);
End

-- Unique Keys

If not exists
	(
		Select *
		From sys.key_constraints kc
		Where kc.parent_object_id = OBJECT_ID(N'School.Semester') and kc.[name] = N'UK_School_Semester_SemesterId_Name'
	)
Begin
	Alter table School.Semester
	Add constraint [UK_School_Semester_SemesterId_Name] unique nonclustered (SemesterId, [Name])
End;