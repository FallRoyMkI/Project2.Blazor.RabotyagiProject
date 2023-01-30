CREATE PROCEDURE [dbo].[Order_GetAllCompleted]
AS
SELECT [Id],[ClientId],[Adress],[Date],[Cost],[Rate],[Report] from [Order]
Where [IsCompleted] = 1
