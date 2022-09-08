CREATE OR ALTER PROCEDURE School.RetrieveUnenrolledInCourses
	@StudentId INT,
	@SemesterId INT
AS

SELECT  C.[Name], C.CourseId
FROM School.Student S
	INNER JOIN (School.Enrollment E
		INNER JOIN School.Course C ON NOT E.CourseId = C.CourseId)
	ON S.StudentId = E.StudentId
WHERE E.StudentId = @StudentId
	AND C.SemesterId = @SemesterId
Group by C.[Name], C.CourseId;
GO
