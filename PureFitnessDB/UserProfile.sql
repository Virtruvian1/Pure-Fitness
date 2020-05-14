CREATE TABLE [dbo].[UserProfile]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [MiddleInitial] NCHAR(1) NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [NickName] NVARCHAR(50) NULL, 
    [UserName] NVARCHAR(50) NOT NULL, 
    [EmailAddress] NVARCHAR(100) NOT NULL, 
    [AccreditedProfile] NVARCHAR(MAX) NOT NULL
)
