CREATE PROCEDURE [dbo].[spSession_DeleteLastOne]
	@UserId int
AS
BEGIN
	DELETE FROM 
		[dbo].[Session]
	WHERE
		[ID] = 
		(
			SELECT TOP 1 [ID] FROM [dbo].[Session] WHERE [UserID] = @UserId ORDER BY [ID] DESC 
		)
END
