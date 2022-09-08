CREATE OR ALTER PROCEDURE School.RetrieveStudentCourses
	@StudentId INT,
	@SemesterId INT
AS

SELECT  C.[Name], C.CourseId
FROM School.Student S
	INNER JOIN (School.Enrollment E
		INNER JOIN School.Course C ON E.CourseId = C.CourseId)
	ON S.StudentId = E.StudentId
WHERE S.StudentId = @StudentId
	AND C.SemesterId = @SemesterId;
GO