CREATE PROCEDURE [dbo].[Service_UpdateById]
@Id int,
@Type nvarchar(50),
@IsDeleted bit
AS
Update [Service]
SET [Type]=@Type,[IsDeleted]=@IsDeleted
Where [Id]=@Id
