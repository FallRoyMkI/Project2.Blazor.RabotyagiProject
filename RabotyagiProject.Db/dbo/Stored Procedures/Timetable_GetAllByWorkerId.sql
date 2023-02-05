CREATE PROCEDURE [dbo].[Timetable_GetAllByWorkerId]
@WorkerId int
AS
Select [Id], [WorkerId], [WorkingDayId] from [dbo].[Timetable] 
Where [WorkerId]= @WorkerId