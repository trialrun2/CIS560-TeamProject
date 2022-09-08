CREATE OR ALTER PROCEDURE School.FetchStudentName
	@StudentId INT
AS

SELECT  (P.FirstName + ' ' +  P.LastName) AS [Name]
FROM School.Student S
	INNER JOIN School.Person P ON P.PersonId = S.PersonId
WHERE S.StudentId = @StudentId;
GO