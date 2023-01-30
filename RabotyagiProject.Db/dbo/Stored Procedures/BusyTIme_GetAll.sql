CREATE PROCEDURE [dbo].[BusyTIme_GetAll]
AS
Select [Id],[TimetableId],[StartTime],[EndTime] from [BusyTime]
Where [IsDeleted] <> 1