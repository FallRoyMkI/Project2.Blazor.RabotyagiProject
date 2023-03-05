CREATE PROCEDURE [dbo].[Order_UpdateServiceByOrderIdAndServiceId]
@OrderId int,
@ServiceId int,
@WorkerId int,
@Workload int
AS
Update [Order_Service_Worker]
SET [WorkerId]=@WorkerId,[Workload]=@Workload
Where [OrderId]=@OrderId and [ServiceId]=@ServiceId