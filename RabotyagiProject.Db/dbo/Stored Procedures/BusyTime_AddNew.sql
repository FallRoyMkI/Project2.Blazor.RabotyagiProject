CREATE PROCEDURE [dbo].[BusyTime_AddNew]
@StartTime time,
@EndTime time,
@TimetableId int
AS
INSERT [BusyTime]([StartTime],[EndTime],[TimetableId],[IsDeleted])
VALUES (@StartTime,@EndTime,@TimetableId,0)
