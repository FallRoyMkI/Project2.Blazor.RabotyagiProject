CREATE PROCEDURE [dbo].[Order_GetAllServiceByOrderId]
@Id int
AS
SELECT [ServiceId],[WorkerId],[Workload] from [Order_Service_Worker] 
Where [OrderId] = @Id 