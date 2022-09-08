﻿CREATE OR ALTER PROCEDURE School.RetrieveAllAssignments
	@CourseId INT
AS

SELECT A.[Name]
FROM School.Assignments A
WHERE A.CourseId = @CourseId;
GO