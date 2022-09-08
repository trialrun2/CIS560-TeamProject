If OBJECT_ID(N'School.Enrollment') is null
Begin
	Create table School.Enrollment
	(
		StudentId INT not null,
		CourseId INT not null,
		EnrollmentDate DATETIMEOFFSET not null default(SYSDATETIMEOFFSET()),
		DroppedDate DATETIMEOFFSET null 

		Constraint [PK_School_Enrollment_StudentId_CourseId] primary key clustered (StudentId asc, CourseId asc),
		Constraint [FK_School_Enrollment_Student_Student] foreign key (StudentId) references School.Student(StudentId),
		Constraint [FK_School_Enrollment_Course_Course] foreign key (CourseId) references School.Course(CourseId)
	);
End