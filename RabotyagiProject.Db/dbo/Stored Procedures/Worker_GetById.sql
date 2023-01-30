CREATE PROCEDURE [dbo].[Worker_GetById]
	@Id int
AS
Select [Name],[Phone],[Mail],[IsDeleted] from [Worker] 
Where [Id]=@Id
