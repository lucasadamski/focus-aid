CREATE PROCEDURE [dbo].[spSession_GetAll]
	@UserId int
AS
BEGIN
	SELECT 
		[Id]
		,[DateCreated]
		,[Time]
		,[Focused]
		,[Description]
		,[UserID]
	FROM 
		[dbo].[Session]
	WHERE 
		[UserId] = @UserId;
END