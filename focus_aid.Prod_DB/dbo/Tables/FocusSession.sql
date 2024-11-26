CREATE TABLE [dbo].[FocusSession]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[DateCreated] DATETIME NOT NULL,
	[Time] INT NOT NULL,
	[Focused] BIT  NOT NULL,
	[FocusDescription] CHAR(25),
	[DistractionDescription] CHAR(25),
	[UserID] CHAR(40) NOT NULL
)
