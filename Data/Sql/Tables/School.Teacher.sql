If OBJECT_ID(N'School.Teacher') is null
Begin
	Create table School.Teacher
	(
		TeacherId INT NOT NULL IDENTITY(1, 1),
		PersonId INT NOT NULL 

		Constraint [PK_School_Teacher_TeacherId] primary key clustered (TeacherId ASC),
		Constraint [FK_School_Teacher_Person_Person] foreign key (PersonId) references School.Person(PersonId)
	);
END;

-- Unique Keys:

If not exists 
	(
		Select * 
		From sys.key_constraints kc
		Where kc.parent_object_id = OBJECT_ID(N'School.Teacher') and kc.[name] = N'UK_School_Teacher_TeacherId_PersonId'
	)
Begin
	Alter table School.Teacher
	Add Constraint [UK_School_Teacher_TeacherId_PersonId] unique nonclustered (TeacherId, PersonId)
End;