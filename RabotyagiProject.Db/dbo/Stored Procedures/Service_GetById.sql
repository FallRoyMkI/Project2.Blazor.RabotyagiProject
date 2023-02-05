CREATE PROCEDURE [dbo].[Service_GetById]
@Id int
AS
Select [Id], [Type],[IsDeleted] from [Service]
Where [Id] = @Id