If OBJECT_ID(N'School.SubmittedAssignment') is null
Begin
	Create table School.SubmittedAssignment 
	(
		AssignmentId INT not null,
		StudentId INT not null,
		EarnedPoints INT null,
		TurnedInDate DATETIMEOFFSET not null default(SYSDATETIMEOFFSET()),
		Removed BIT not null

		Constraint [PK_School_SubmittedAssignment_AssignmentId_StudentId] primary key clustered (AssignmentId asc, StudentId asc),
		Constraint [FK_School_SubmittedAssignment_Assignment_Assignment] foreign key (AssignmentId) references School.Assignments(AssignmentId),
		Constraint [FK_School_SubmittedAssignment_Student_Student] foreign key (StudentId) references School.Student(StudentId)
	);
End
