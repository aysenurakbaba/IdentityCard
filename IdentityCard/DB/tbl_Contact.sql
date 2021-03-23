CREATE TABLE tbl_Contact
(
	[ContactId] INT NOT NULL PRIMARY KEY, 
    [IdentityId] INT NOT NULL IDENTITY, 
    [SurName] NVARCHAR(20) NOT NULL, 
    [Name] NVARCHAR(20) NOT NULL, 
    [BirthDate] DATE NOT NULL, 
    [DocumentNo] NVARCHAR(50) NOT NULL, 
    [ValidUntil] DATE NOT NULL, 
    [Gender] CHAR(10) NOT NULL, 
    [Naltionality] CHAR(10) NOT NULL
)
