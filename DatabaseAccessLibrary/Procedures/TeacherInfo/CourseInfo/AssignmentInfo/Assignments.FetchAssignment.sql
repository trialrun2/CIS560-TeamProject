CREATE OR ALTER PROCEDURE School.FetchAssignment
	@Name NVARCHAR(32),
	@CourseId INT
AS

SELECT A.[Name]
FROM School.Assignments A
WHERE A.CourseId = @CourseId
	AND A.[Name] = @Name;
GO