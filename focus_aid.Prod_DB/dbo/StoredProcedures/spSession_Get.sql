CREATE PROCEDURE [dbo].[spSession_Get]
	@Id int
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
		[Id] = @Id;
END
