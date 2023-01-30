CREATE PROCEDURE [dbo].[Order_AddNew]
@ClientId int,
@Adress nvarchar(50),
@Date date
AS
INSERT [Order]([ClientId],[IsCompleted],[Adress],[Date],[IsDeleted])
values (@ClientId,0,@Adress,@Date,0)