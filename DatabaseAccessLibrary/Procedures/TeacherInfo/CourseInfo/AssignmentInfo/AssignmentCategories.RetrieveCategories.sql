CREATE OR ALTER PROCEDURE School.RetrieveCategories
	@CourseId INT
AS

SELECT AC.[Name]
FROM School.AssignmentCategories AC
WHERE @CourseId = AC.CourseId;
GO