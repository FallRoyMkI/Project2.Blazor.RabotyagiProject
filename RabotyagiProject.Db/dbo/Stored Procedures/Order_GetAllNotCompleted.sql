CREATE PROCEDURE [dbo].[Order_GetAllNotCompleted]
AS
SELECT [Id],[ClientId],[IsCompleted],[Adress],[Date],[Cost],[Rate],[Report] from [Order]
Where [IsCompleted] <>1 and [IsDeleted] <> 1