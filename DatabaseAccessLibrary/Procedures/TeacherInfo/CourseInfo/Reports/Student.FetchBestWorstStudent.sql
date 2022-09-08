CREATE OR ALTER PROCEDURE School.FetchBestWorstStudent
	@SemesterName NVARCHAR(32),
	@TeacherId INT
AS

SELECT C.[Name], 
	(
		SELECT (P.FirstName + ' ' + P.LastName) AS [Name]
		FROM School.Person P
			INNER JOIN (School.Student S
				INNER JOIN (School.SubmittedAssignment SA
					INNER JOIN (School.Assignments A
						INNER JOIN (School.Course C 
							INNER JOIN School.Semester SE ON C.SemesterId = SE.SemesterId)
						ON C.CourseId = A.CourseId)
					ON A.AssignmentId = SA.AssignmentId)
				ON SA.StudentId = S.StudentId)
			ON S.PersonId = P.PersonId
		WHERE C.TeacherId = @TeacherId
			AND SE.[Name] = @SemesterName
	) AS BestStudentName,
	(
		SELECT SUM(SA.EarnedPoints)/COUNT(SA.AssignmentId)
		FROM School.Person P
			INNER JOIN (School.Student S
				INNER JOIN (School.SubmittedAssignment SA
					INNER JOIN (School.Assignments A
						INNER JOIN (School.Course C 
							INNER JOIN School.Semester SE ON C.SemesterId = SE.SemesterId)
						ON C.CourseId = A.CourseId)
					ON A.AssignmentId = SA.AssignmentId)
				ON SA.StudentId = S.StudentId)
			ON S.PersonId = P.PersonId
		WHERE C.TeacherId = @TeacherId
			AND SE.[Name] = @SemesterName
	) AS BestStudentGrade,
	(
		SELECT (P.FirstName + ' ' + P.LastName) AS [Name]
		FROM School.Person P
			INNER JOIN (School.Student S
				INNER JOIN (School.SubmittedAssignment SA
					INNER JOIN (School.Assignments A
						INNER JOIN (School.Course C 
							INNER JOIN School.Semester SE ON C.SemesterId = SE.SemesterId)
						ON C.CourseId = A.CourseId)
					ON A.AssignmentId = SA.AssignmentId)
				ON SA.StudentId = S.StudentId)
			ON S.PersonId = P.PersonId
		WHERE C.TeacherId = @TeacherId
			AND SE.[Name] = @SemesterName
	) AS WorstStudentName,
	(
		SELECT SUM(SA.EarnedPoints)/COUNT(SA.AssignmentId)
		FROM School.Person P
			INNER JOIN (School.Student S
				INNER JOIN (School.SubmittedAssignment SA
					INNER JOIN (School.Assignments A
						INNER JOIN (School.Course C 
							INNER JOIN School.Semester SE ON C.SemesterId = SE.SemesterId)
						ON C.CourseId = A.CourseId)
					ON A.AssignmentId = SA.AssignmentId)
				ON SA.StudentId = S.StudentId)
			ON S.PersonId = P.PersonId
		WHERE C.TeacherId = @TeacherId
			AND SE.[Name] = @SemesterName
	) AS WorstStudentGrade
FROM School.Course C 
	INNER JOIN School.Semester S ON C.SemesterId = S.SemesterId
WHERE C.TeacherId = @TeacherId
	AND S.[Name] = @SemesterName;

GO
