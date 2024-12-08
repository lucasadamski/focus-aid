IF NOT EXISTS (SELECT 1 FROM [dbo].[Session])
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
		'2024-01-01'
		, 45
		, 1
		, 'Test Description'
		, 'TestUserID'
	)
END