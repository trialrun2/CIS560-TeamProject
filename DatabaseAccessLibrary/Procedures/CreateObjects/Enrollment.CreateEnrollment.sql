CREATE OR ALTER PROCEDURE School.CreateEnrollment
	@StudentId INT,
	@CourseId INT,
	@EnrollmentDate DATETIMEOFFSET,
	@DroppedDate DATETIMEOFFSET
AS

INSERT School.Enrollment(StudentId, CourseId, EnrollmentDate, DroppedDate)
VALUES(@StudentId, @CourseId, @EnrollmentDate, @DroppedDate);

GO