CREATE OR ALTER PROCEDURE School.FetchGradeAvg
	@StudentId INT
AS

SELECT  SUM(SA.EarnedPoints)/COUNT(SA.AssignmentId) AS AvgGrade
FROM School.Student S
	INNER JOIN School.SubmittedAssignment SA ON SA.StudentId = S.StudentId
WHERE S.StudentId = @StudentId;
GO