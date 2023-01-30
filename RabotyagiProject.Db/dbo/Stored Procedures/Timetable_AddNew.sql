CREATE PROCEDURE [dbo].[Timetable_AddNew]
	@WorkerId int ,
	@WorkingDayId int
AS
Insert [Timetable]([WorkerId],[WorkingDayId],[IsDeleted])
Values (@WorkerId,@WorkingDayId,0)
