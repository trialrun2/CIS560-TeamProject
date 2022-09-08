CREATE OR ALTER PROCEDURE School.FetchTeacherCourses
	@TeacherId INT,
	@CurrentSemester INT
AS

SELECT COUNT(C.CourseId)
FROM School.Course C
WHERE C.TeacherId = @TeacherId
	AND C.SemesterId = @CurrentSemester;
GO