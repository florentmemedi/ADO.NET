USE AdoNetDB

GO
CREATE PROCEDURE AddAuthor
	@FirstName NVARCHAR(30),
	@LastName NVARCHAR(30)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].Author
	VALUES
	(
		@FirstName,
		@LastName
	);
END
GO
