CREATE PROCEDURE [dbo].[Worker_GetById]
	@Id int
AS
Select [Id],[Name],[Phone],[Mail],[IsDeleted] from [Worker] 
Where [Id]=@Id
