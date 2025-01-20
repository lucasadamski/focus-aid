CREATE TABLE [dbo].[Session]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[DateCreated] DATETIME NOT NULL,
	[Time] INT NOT NULL,
	[Focused] BIT  NOT NULL, -- rename to Success
	[Description] CHAR(25),
	[UserID] CHAR(40) NOT NULL
)
