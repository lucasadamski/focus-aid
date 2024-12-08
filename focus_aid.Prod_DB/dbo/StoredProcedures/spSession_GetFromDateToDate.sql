CREATE PROCEDURE [dbo].[spSession_GetFromDateToDate]
	@from dateTime,
	@to dateTime
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
		[DateCreated] >= @from 
		AND [DateCreated] <= @from
END
