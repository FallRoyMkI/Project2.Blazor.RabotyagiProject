CREATE PROCEDURE [dbo].[WorkingDay_AddNew]
	@Date date
AS
Insert [WorkingDay]([Date])
Values (@Date)
