If OBJECT_ID(N'School.Person') is null
Begin
	Create table School.Person
	(
		PersonId INT not null identity(1, 1),
		FirstName NVARCHAR(20) not null,
		LastName NVARCHAR(20) not null,
		PasswordHash NVARCHAR(50) not null

		Constraint [PK_School_Person_PersonId] primary key clustered (PersonId asc)
	);
End