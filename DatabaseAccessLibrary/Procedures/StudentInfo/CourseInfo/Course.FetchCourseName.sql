CREATE OR ALTER PROCEDURE School.FetchCourseName
	@CourseId INT,
	@SemesterId INT
AS

SELECT  C.[Name]
FROM School.Course C
WHERE C.CourseId = @CourseId
	AND C.SemesterId = @SemesterId;
GO