CREATE PROCEDURE [dbo].[Order_GetById]
@Id int
AS
SELECT [ClientId],[IsCompleted],[Adress],[Date],[Cost],[Rate],[Report],[IsDeleted] from [Order]

