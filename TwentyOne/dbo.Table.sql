CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ExcetionType] VARCHAR(50) NULL, 
    [ExceptionMessage] VARCHAR(200) NULL, 
    [TimeStamp] DATETIME NULL
)
