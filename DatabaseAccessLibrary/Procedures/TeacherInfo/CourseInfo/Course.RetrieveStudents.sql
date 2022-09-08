CREATE OR ALTER PROCEDURE School.RetrieveStudents
	@CourseId INT
AS

SELECT (P.FirstName + ' ' + P.LastName) AS [Name]
FROM School.Course C
	INNER JOIN (School.Enrollment E
		INNER JOIN (School.Student S
			INNER JOIN School.Person P ON P.PersonId = S.PersonId)
		ON S.StudentId = E.StudentId)
	ON E.CourseId = C.CourseId
WHERE C.CourseId = @CourseId