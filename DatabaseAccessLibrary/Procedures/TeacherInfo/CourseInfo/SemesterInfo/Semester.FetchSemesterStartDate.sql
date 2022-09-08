CREATE OR ALTER PROCEDURE School.FetchSemesterStartDate
	@SemesterId INT
AS

SELECT S.StartDate
FROM School.Semester S
WHERE S.SemesterId = @SemesterId;
GO

