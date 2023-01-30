CREATE PROCEDURE [dbo].[Service_AddNew]
@Type nvarchar(50)
AS
Insert [Service]([Type],[IsDeleted]) 
Values (@Type,0)