CREATE PROCEDURE [dbo].[Order_GetAllByClientId]
@Id int
AS
SELECT [Id],[ClientId],[IsCompleted],[Adress],[Date],[Cost],[Rate],[Report] from [Order]
where [ClientId] = @Id and [IsDeleted] <> 1
