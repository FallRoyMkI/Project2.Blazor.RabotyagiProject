CREATE PROCEDURE [dbo].[Timetable_GetAll]
AS
Select [Id],[WorkerId],[WorkingDayId] from [Timetable] 
Where [IsDeleted] <> 1

