CREATE OR ALTER PROCEDURE School.FetchTeacher
	@TeacherId INT
AS

SELECT P.FirstName, P.LastName
FROM School.Teacher T
	INNER JOIN School.Person P ON P.PersonId = T.TeacherId
WHERE @TeacherId = T.TeacherId;
GO