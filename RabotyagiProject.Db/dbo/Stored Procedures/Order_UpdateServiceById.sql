CREATE PROCEDURE [dbo].[Order_UpdateServiceById]
@Id int,
@OrderId int,
@ServiceId int,
@WorkerId int,
@Workload int
AS
Update [Order_Service_Worker]
SET [OrderId]=@OrderId,[ServiceId]=@ServiceId,[WorkerId]=@WorkerId,[Workload]=@Workload
Where [Id]=@Id