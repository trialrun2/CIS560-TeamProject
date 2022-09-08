CREATE OR ALTER PROCEDURE School.CreateCourse
	@TeacherId INT,
	@SemesterId INT,
	@Name NVARCHAR(32),
	@StudentCapacity INT,
	@CourseId INT OUTPUT
AS

INSERT School.Course(TeacherId, SemesterId, [Name], StudentCapacity)
VALUES(@TeacherId, @SemesterId, @Name, @StudentCapacity);

SET @CourseId = SCOPE_IDENTITY();
GO