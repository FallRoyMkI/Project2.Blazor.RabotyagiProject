CREATE PROCEDURE [dbo].[Order_GetAllByClientId]
@Id int
AS
SELECT [Id],[IsCompleted],[Adress],[Date],[Cost],[Rate],[Report],[IsDeleted] from [Order]
where [ClientId] = @Id
