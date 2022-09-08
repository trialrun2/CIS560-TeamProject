CREATE OR ALTER PROCEDURE School.FetchCourseCount
	@StudentId INT
AS

SELECT  COUNT(E.CourseId)
FROM School.Student S
	INNER JOIN School.Enrollment E ON S.StudentId = E.StudentId
WHERE S.StudentId = @StudentId;
GO