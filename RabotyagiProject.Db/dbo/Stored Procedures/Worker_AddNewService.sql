CREATE PROCEDURE [dbo].[Worker_AddNewService]
@WorkerId int,
@ServiceId int,
@Cost int
AS
Insert [Worker_Service]([WorkerId],[ServiceId],[Cost]) 
Values (@WorkerId,@ServiceId,@Cost)
