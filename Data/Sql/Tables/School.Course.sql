If OBJECT_ID(N'School.Course') is null
Begin
	Create table School.Course
	(
		CourseId INT not null identity(1, 1),
		TeacherId INT not null,
		SemesterId INT not null,
		[Name] NVARCHAR(50) not null,
		StudentCapacity INT not null

		Constraint [PK_School_Course_CourseId] primary key clustered (CourseId asc),
		Constraint [FK_School_Course_Teacher_Teacher] foreign key (TeacherId) references School.Teacher(TeacherId),
		Constraint [FK_School_Course_Semester_Semester] foreign key (SemesterId) references School.Semester(SemesterId)
	);
End
