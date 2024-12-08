CREATE PROCEDURE [dbo].[spSession_Insert]
		@DateCreated datetime
		,@Time int
		,@Focused bit
		,@Description char(25)
		,@UserID char(40)
AS
BEGIN
	INSERT INTO [dbo].[Session] 
	(
			[DateCreated]
			,[Time]
			,[Focused]
			,[Description]
			,[UserID]
		)
	VALUES 
		(
			@DateCreated
			,@Time
			,@Focused
			,@Description
			,@UserID
		)
END
