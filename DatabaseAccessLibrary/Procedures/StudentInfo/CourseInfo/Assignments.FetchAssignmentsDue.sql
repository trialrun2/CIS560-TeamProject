CREATE OR ALTER PROCEDURE School.FetchAssignmentsDue
	@StudentId INT,
	@CourseId INT
AS

SELECT A.[Name], A.AssignmentId, A.AssignmentCategoryId, A.AssignedDate, A.DueDate, A.TotalPoints
FROM School.Assignments A
	inner join School.Enrollment E on E.CourseId = A.CourseId
	left join School.SubmittedAssignment SA on SA.AssignmentId = A.AssignmentId
WHERE E.StudentId = @StudentId
	AND A.CourseId = @CourseId
Group by A.[Name], A.AssignmentId, A.AssignmentCategoryId, A.AssignedDate, A.DueDate, A.TotalPoints
GO
