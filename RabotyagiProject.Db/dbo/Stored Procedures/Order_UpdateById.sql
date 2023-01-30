CREATE PROCEDURE [dbo].[Order_UpdateById]
@Id int,
@ClientId int,
@IsCompleted bit,
@Adress nvarchar(50),
@Date date,
@Cost int,
@Rate int,
@Report nvarchar(50),
@IsDeleted bit
AS
Update [Order]
SET [ClientId]=@ClientId,[IsCompleted]=@IsCompleted,[Adress]=@Adress,[Date]=@Date,[Cost]=@Cost,[Rate]=@Rate,[Report]=@Report,[IsDeleted]=@IsDeleted
where [Id]=@Id