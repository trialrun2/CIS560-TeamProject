CREATE OR ALTER PROCEDURE School.FetchStudentCount
	@CourseId INT
AS

SELECT COUNT(E.StudentId), C.StudentCapacity
FROM School.Course C
	INNER JOIN School.Enrollment E ON E.CourseId = C.CourseId
WHERE C.CourseId = @CourseId
GROUP BY C.StudentCapacity;
GO