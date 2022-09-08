Create or Alter Procedure School.FetchIDFromName
	@FirstName NVARCHAR(20),
	@LastName NVARCHAR(20)
AS

SELECT P.PersonId
FROM School.Person P
WHERE P.FirstName = @FirstName and P.LastName = @LastName
GO