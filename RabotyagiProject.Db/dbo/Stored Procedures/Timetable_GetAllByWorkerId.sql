CREATE PROCEDURE [dbo].[Timetable_GetAllByWorkerId]
@WorkerId int
AS
Select T.[Id],WD.[Date],T.[IsDeleted] from [dbo].[Timetable] as T
Inner join [dbo].[WorkingDay] as WD ON T.[WorkingDayId]=WD.[Id]
Where T.[WorkerId]= @WorkerId