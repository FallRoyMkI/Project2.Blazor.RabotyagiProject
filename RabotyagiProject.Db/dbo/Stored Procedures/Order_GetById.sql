CREATE PROCEDURE [dbo].[Order_GetById]
@Id int
AS
SELECT [Id],[ClientId],[IsCompleted],[Adress],[Date],[Cost],[Rate],[Report],[IsDeleted] from [Order]
where [Id] = @Id 
