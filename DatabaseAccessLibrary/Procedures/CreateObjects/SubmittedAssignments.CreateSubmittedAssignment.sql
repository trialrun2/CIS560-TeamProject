CREATE OR ALTER PROCEDURE School.CreateSubmittedAssignment
	@AssignmentId INT,
	@StudentId	INT,
	@EarnedPoints INT,
	@TurnedInDate DATETIMEOFFSET,
	@Removed BIT
AS

INSERT School.SubmittedAssignment(AssignmentId, StudentId, EarnedPoints, TurnedInDate, Removed)
VALUES(@AssignmentId, @StudentId, @EarnedPoints, @TurnedInDate, @Removed);

GO