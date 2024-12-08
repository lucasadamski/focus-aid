CREATE PROCEDURE [dbo].[spBeeper_Insert]
		@Time int
		,@Type int
		,@UserID char(40)
AS
BEGIN
	INSERT INTO [dbo].[Beeper] 
	(
			[Time]
			,[Type]
			,[UserID]
		)
	VALUES 
		(
			@Time
			,@Type
			,@UserID
		)
END
