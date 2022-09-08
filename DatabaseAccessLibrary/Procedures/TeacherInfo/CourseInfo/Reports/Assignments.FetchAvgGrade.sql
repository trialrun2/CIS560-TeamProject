CREATE OR ALTER PROCEDURE School.FetchAvgGrade
	@CourseName NVARCHAR(32)
AS

SELECT A.[Name], SUM(SA.EarnedPoints)/COUNT(SA.AssignmentId) AS AverageGrade, 
	AC.[Name], RANK() OVER(
		PARTITION BY AC.AssignmentCategoryId
		ORDER BY SUM(SA.EarnedPoints)/COUNT(SA.AssignmentId) DESC
	) AS CategoryRank
FROM School.Course C
	INNER JOIN (School.AssignmentCategories AC
		INNER JOIN (School.Assignments A
			INNER JOIN School.SubmittedAssignment SA ON SA.AssignmentId = A.AssignmentId)
		ON AC.AssignmentCategoryId = A.AssignmentCategoryId)
	ON AC.CourseId = C.CourseId
WHERE C.[Name] = @CourseName
GROUP BY A.[Name], AC.[Name], AC.AssignmentCategoryId;
GO