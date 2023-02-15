CREATE PROCEDURE [dbo].[GetAll]
AS
Select [Id],[Type] from [Service]
Where [IsDeleted] <> 1
