CREATE PROCEDURE [dbo].[ContactAdd]
@mode nvarchar(10), 
@ContactId INT ,
@IdentityId INT , 
@SurName NVARCHAR(20), 
@Name NVARCHAR(20) , 
@BirthDate DATE , 
@DocumentNo NVARCHAR(50) , 
@ValidUntil DATE , 
@Gender CHAR(10) , 
@Naltionality CHAR(10) 
AS
	if @mode = 'Add'
	BEGIN
		INSERT INTO dbo.Table_Contact
		(
		 IdentityId , 
		 SurName , 
		 Name , 
		 BirthDate , 
		 DocumentNo , 
		 ValidUntil , 
		 Gender, 
		 Naltionality 
		)
		VALUES 
		(
		 @IdentityId,
		 @SurName,
		 @Name,
		 @BirthDate,
		 @DocumentNo, 
		 @ValidUntil, 
		 @Gender, 
		 @Naltionality 
		)
	END


