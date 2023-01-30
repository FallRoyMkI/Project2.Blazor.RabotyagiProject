CREATE PROCEDURE [dbo].[Order_AddNewService]
@OrderId int,
@ServiceId int,
@Workload int
AS
Insert [Order_Service_Worker]([OrderId],[ServiceId],[Workload]) 
Values (@OrderId,@ServiceId,@Workload)
