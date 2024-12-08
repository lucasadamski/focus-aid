CREATE PROCEDURE [dbo].[spBeeper_Update]
		@Time int
		,@Type int
		,@UserID char(40)
AS
BEGIN
	UPDATE [dbo].[Beeper] 
	SET [Time] = @Time
		,[Type] = @Type
	WHERE 
		[UserID] = @UserID
END

