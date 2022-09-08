CREATE OR ALTER PROCEDURE School.FetchTeacherCourses
	@TeacherId INT,
	@CurrentSemester INT
AS

SELECT C.[Name]
FROM School.Course C
WHERE C.TeacherId = @TeacherId
	AND C.SemesterId = @CurrentSemester;
GO