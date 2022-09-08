If OBJECT_ID(N'School.Student') is null
Begin 
	Create table School.Student
	(
		StudentId INT not null identity(1, 1),
		PersonId INT not null

		constraint [PK_School_Student_StudentId] primary key clustered (StudentId),
		constraint [FK_School_Student_Person_Person] foreign key (PersonId) references School.Person(PersonId)
	);
End

-- Unique constraints

If not exists 
	(
		Select *
		From sys.key_constraints kc
		Where kc.parent_object_id = OBJECT_ID(N'School.Student') and kc.[name] = N'UK_School_Student_StudentId_PersonId'
	)
Begin
	Alter table School.Student
	Add constraint [UK_School_Student_StudentId_PersonId] unique nonclustered (StudentId, PersonId)
End;