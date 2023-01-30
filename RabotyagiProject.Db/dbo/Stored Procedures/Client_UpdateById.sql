CREATE PROCEDURE [dbo].[Client_UpdateById]
@Id int,
@Name nvarchar(50),
@Phone nvarchar(11),
@Mail nvarchar(50),
@IsDeleted bit
AS
Update [Client]
SET [Name]= @Name, [Phone]=@Phone, [Mail]=@Mail,[IsDeleted]=@IsDeleted
Where [Id]= @Id
