CREATE OR ALTER PROCEDURE School.CreateAssignment
	@AssignmentCategoryId INT,
	@CourseId INT,
	@Name NVARCHAR(32),
	@AssignedDate  DATETIMEOFFSET,
	@DueDate DATETIMEOFFSET,
	@TotalPoints INT,
	@Removed BIT,
	@AssignmentId INT OUTPUT
AS

INSERT School.Assignments(AssignmentCategoryId, CourseId, [Name], AssignedDate, DueDate, TotalPoints, Removed)
VALUES(@AssignmentCategoryId, @CourseId, @Name, @AssignedDate, @DueDate, @TotalPoints, @Removed);

SET @AssignmentCategoryId = SCOPE_IDENTITY();
GO