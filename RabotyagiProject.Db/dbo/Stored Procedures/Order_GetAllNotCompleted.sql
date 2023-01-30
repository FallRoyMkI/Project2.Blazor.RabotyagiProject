CREATE PROCEDURE [dbo].[Order_GetAllNotCompleted]
AS
SELECT [Id],[ClientId],[Adress],[Date],[Cost],[Rate],[Report],[IsDeleted] from [Order]
Where [IsCompleted] <>1