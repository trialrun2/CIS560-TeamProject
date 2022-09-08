CREATE OR ALTER PROCEDURE School.FetchCourseGrade
	@StudentId INT,
	@CourseId INT
AS

SELECT SUM(SA.EarnedPoints)/ SUM(A.TotalPoints) AS CourseGrade
FROM School.SubmittedAssignment SA
	INNER JOIN School.Assignments A ON SA.AssignmentId = A.AssignmentId
WHERE SA.StudentId = @StudentId
	AND A.CourseId = @CourseId;
GO