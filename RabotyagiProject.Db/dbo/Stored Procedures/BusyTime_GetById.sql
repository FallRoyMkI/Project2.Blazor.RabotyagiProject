CREATE PROCEDURE [dbo].[BusyTime_GetById]
@Id int
AS
SELECT [Id],[TimetableId],[StartTime],[EndTime],[IsDeleted] from [dbo].[BusyTime]
Where [Id]=@Id
