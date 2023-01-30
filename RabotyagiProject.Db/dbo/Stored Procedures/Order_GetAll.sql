CREATE PROCEDURE [dbo].[Order_GetAll]
AS
SELECT [Id],[ClientId],[IsCompleted],[Adress],[Date],[Cost],[Rate],[Report] from [Order]
Where [IsDeleted] <> 1
