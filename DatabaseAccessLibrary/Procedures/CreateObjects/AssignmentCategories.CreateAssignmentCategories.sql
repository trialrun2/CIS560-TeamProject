CREATE OR ALTER PROCEDURE School.CreateAssignmentCategories
	@CourseId INT,
	@Name NVARCHAR(32),
	@AssignmentCategoriesId INT OUTPUT
AS

INSERT School.AssignmentCategories(CourseId, [Name])
VALUES (@CourseId, @Name);

SET @AssignmentCategoriesId = SCOPE_IDENTITY();
GO