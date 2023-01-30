CREATE PROCEDURE [dbo].[Timetable_UpdateById]
@Id int,
@WorkerId int ,
@WorkingDayId int,
@IsDeleted bit
AS
Update [Timetable]
SET [WorkerId]=@WorkerId,[WorkingDayId]= @WorkingDayId,[IsDeleted]=@IsDeleted
Where [Id]=@Id