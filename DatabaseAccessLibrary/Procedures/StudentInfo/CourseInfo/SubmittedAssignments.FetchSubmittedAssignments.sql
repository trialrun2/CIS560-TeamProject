CREATE OR ALTER PROCEDURE School.FetchSubmittedAssignments
	@StudentId INT,
	@CourseId INT
AS

SELECT A.[Name], SA.EarnedPoints, SA.AssignmentId, SA.TurnedInDate
FROM School.SubmittedAssignment SA
	INNER JOIN School.Assignments A ON SA.AssignmentId = A.AssignmentId
WHERE SA.StudentId = @StudentId
	AND A.CourseId = @CourseId;
GO