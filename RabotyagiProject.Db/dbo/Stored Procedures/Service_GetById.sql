CREATE PROCEDURE [dbo].[Service_GetById]
@Id int
AS
Select [Type],[IsDeleted] from [Service]
Where [Id] = @Id