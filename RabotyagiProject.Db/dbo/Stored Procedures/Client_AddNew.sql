CREATE PROCEDURE [dbo].[Client_AddNew]
@Name nvarchar(50),
@Phone nvarchar(11),
@Mail nvarchar(50)
AS
Insert [Client]([Name],[Phone],[Mail],[IsDeleted]) 
Values (@Name,@Phone,@Mail,0)