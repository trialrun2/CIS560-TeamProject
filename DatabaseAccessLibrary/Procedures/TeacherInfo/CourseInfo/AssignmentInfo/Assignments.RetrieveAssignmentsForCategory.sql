CREATE OR ALTER PROCEDURE School.RetrieveAllAssignments
	@CourseId INT,
	@AssignmentsCategoryId INT
AS

SELECT A.[Name]
FROM School.Assignments A
WHERE A.CourseId = @CourseId
	AND A.AssignmentCategoryId = @AssignmentsCategoryId;
GO