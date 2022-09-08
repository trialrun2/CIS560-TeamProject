CREATE OR ALTER PROCEDURE School.BestStudentsForCourse
	@CourseName NVARCHAR(32)
AS

SELECT RANK() OVER(
	ORDER BY SUM(SA.EarnedPoints)/COUNT(SA.AssignmentId)
	) AS StudentRank, (P.FirstName + ' ' + P.LastName) AS [Name],  SUM(SA.EarnedPoints)/COUNT(SA.AssignmentId) AS StudentGrade,
	(
		SELECT AC.[Name]
		FROM School.Student S
			INNER JOIN (School.SubmittedAssignment SA
				INNER JOIN (School.Assignments A
					INNER JOIN (School.Course C
						INNER JOIN School.AssignmentCategories AC ON C.CourseId = AC.CourseId)
					ON A.CourseId = C.CourseId)
				ON SA.AssignmentId = A.AssignmentId)
			ON S.StudentId = SA.StudentId
		WHERE @CourseName = C.[Name]
		GROUP BY AC.AssignmentCategoryId,  AC.[Name]
	)AS BestCategory
FROM School.Person P
	INNER JOIN (School.Student S
		INNER JOIN (School.SubmittedAssignment SA
			INNER JOIN (School.Assignments A
				INNER JOIN (School.Course C
					INNER JOIN School.AssignmentCategories AC ON C.CourseId = AC.CourseId)
				ON A.CourseId = C.CourseId)
			ON SA.AssignmentId = A.AssignmentId)
		ON S.StudentId = SA.StudentId)
	ON S.PersonId = P.PersonId
WHERE C.[Name] = @CourseName
GROUP BY P.LastName, P.FirstName
ORDER BY StudentRank
OFFSET 0 ROWS FETCH NEXT 20 ROWS ONLY;

GO

