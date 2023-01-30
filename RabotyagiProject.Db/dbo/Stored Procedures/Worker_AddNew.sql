CREATE PROCEDURE [dbo].[Worker_AddNew]
@Name nvarchar(50),
@Phone nvarchar(11),
@Mail nvarchar(50)
AS
Insert [Worker]([Name],[Phone],[Mail],[IsDeleted]) 
Values (@Name,@Phone,@Mail,0)