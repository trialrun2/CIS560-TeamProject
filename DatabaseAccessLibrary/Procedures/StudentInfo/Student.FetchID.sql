CREATE OR ALTER PROCEDURE School.FetchStudentId
	@PersonId INT
AS

SELECT  S.StudentId
FROM School.Student S
	INNER JOIN School.Person P ON P.PersonId = S.PersonId
WHERE  P.PersonId = @PersonId;
GO
