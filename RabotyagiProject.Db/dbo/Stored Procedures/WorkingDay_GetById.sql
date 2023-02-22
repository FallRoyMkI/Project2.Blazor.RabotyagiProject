CREATE PROCEDURE [dbo].[WorkingDay_GetById]
@Id int
AS
SELECT [Id],[Date] FROM [dbo].[WorkingDay]
Where [Id]=@Id
