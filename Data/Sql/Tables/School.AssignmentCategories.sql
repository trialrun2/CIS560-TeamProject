If OBJECT_ID(N'School.AssignmentCategories') is null
Begin
	Create table School.AssignmentCategories
	(
		AssignmentCategoryId INT not null identity(1, 1),
		CourseId INT not null,
		[Name] NVARCHAR(20) not null

		Constraint [PK_School_AssignmentCategories_AssignmentCategoryId] primary key clustered (AssignmentCategoryId),
		Constraint [FK_School_AssignmentCategories_Course_Course] foreign key (CourseId) references School.Course(CourseId)
	);
End

-- Unique Keys

If not exists 
	(
		Select * 
		From sys.key_constraints kc
		Where kc.parent_object_id = OBJECT_ID(N'School.AssignmentCategories') and kc.[name] = N'UK_School_AssignmentCategories_CourseId_Name'
	)
Begin
	Alter table School.AssignmentCategories
	Add Constraint [UK_School_AssignmentCategories_CourseId_Name] unique nonclustered (CourseId, [Name])
End;