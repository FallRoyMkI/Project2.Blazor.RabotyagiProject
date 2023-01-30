CREATE PROCEDURE [dbo].[WorkingDay_UpdateById]
@Id int,
@Date date
As
Update [WorkingDay]
Set [Date]= @Date
where [Id]= @Id