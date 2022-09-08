CREATE OR ALTER PROCEDURE School.MonthlyScores
	@CourseName NVARCHAR(32),
	@Month INT
AS

SELECT A.[Name], A.DueDate, MAX(SA.EarnedPoints) AS HighScore,
	MIN(SA.EarnedPoints) AS LowScore, SUM(SA.EarnedPoints)/COUNT(SA.StudentId) AS AverageScore,
	COUNT(E.StudentId - SA.StudentId) AS MissingAssignments
FROM School.Enrollment E
	INNER JOIN (School.Course C 
		INNER JOIN (School.Assignments A
			INNER JOIN School.SubmittedAssignment SA ON SA.AssignmentId = A.AssignmentId)
		ON C.CourseId = A.CourseId)
	ON E.CourseId = C.CourseId
WHERE C.[Name] = @CourseName
	AND MONTH(A.DueDate) = @Month
GROUP BY A.[Name], A.DueDate;
GO
