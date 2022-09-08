CREATE OR ALTER PROCEDURE School.GetCurrentSemester
	@SemesterId INT
AS

SELECT S.[Name]
FROM School.Semester S
WHERE S.SemesterId = @SemesterId;
GO
