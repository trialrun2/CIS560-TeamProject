CREATE OR ALTER PROCEDURE School.FetchSemesterEndDate
	@SemesterId INT
AS

SELECT S.EndDate
FROM School.Semester S
WHERE S.SemesterId = @SemesterId;
GO
