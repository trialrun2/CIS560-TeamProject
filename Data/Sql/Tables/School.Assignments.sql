If OBJECT_ID(N'School.Assignments') is null
Begin
	Create table School.Assignments
	(
		AssignmentId INT not null identity(1, 1),
		AssignmentCategoryId INT not null,
		CourseId INT not null,
		[Name] NVARCHAR(50) not null,
		AssignedDate DATETIMEOFFSET not null default(SYSDATETIMEOFFSET()),
		DueDate DATETIMEOFFSET not null default(SYSDATETIMEOFFSET()),
		TotalPoints INT not null,
		Removed BIT not null

		Constraint [PK_School_Assignments_AssignmentId] primary key clustered (AssignmentId asc),
		Constraint [FK_School_Assignments_AssignmentCategories_AssignmentCategories] foreign key (AssignmentCategoryId) references School.AssignmentCategories(AssignmentCategoryId),
		Constraint [FK_School_Assignments_Course_Course] foreign key (CourseId) references School.Course(CourseId)
	);
End

-- Unique Keys

If not exists 
	(
		Select * 
		From sys.key_constraints kc
		Where kc.parent_object_id = OBJECT_ID(N'School.Assignments') and kc.[name] = N'UK_School_Assignments_CourseId_Name'
	)
Begin
	Alter table School.Assignments
	Add Constraint [UK_School_Assignments_CourseId_Name] unique nonclustered (CourseId, [Name])
End;