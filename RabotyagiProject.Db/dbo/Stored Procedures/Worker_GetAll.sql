CREATE PROCEDURE [dbo].[Worker_GetAll]
AS
Select [Id],[Name],[Phone],[Mail] from [Worker] 
Where [IsDeleted] <> 1
