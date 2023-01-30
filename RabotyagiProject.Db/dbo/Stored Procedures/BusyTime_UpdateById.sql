CREATE PROCEDURE [dbo].[BusyTime_UpdateById]
@Id int,
@StartTime time,
@EndTime time,
@TimetableId int,
@IsDeleted bit
AS
Update [BusyTime]
SET [StartTime]=@StartTime,[EndTime]=@EndTime,[TimetableId]=@TimetableId,[IsDeleted]=@IsDeleted
Where [Id]=@Id