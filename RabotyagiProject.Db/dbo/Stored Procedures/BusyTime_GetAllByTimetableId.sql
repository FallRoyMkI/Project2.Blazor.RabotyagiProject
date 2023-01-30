CREATE PROCEDURE [dbo].[BusyTime_GetAllByTimetableId]
@TimetableId int
AS
Select [Id],[StartTime],[EndTime] from [BusyTime]
Where [TimetableId]=@TimetableId and [IsDeleted] <> 1
