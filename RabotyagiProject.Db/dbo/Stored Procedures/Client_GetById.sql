CREATE PROCEDURE [dbo].[Client_GetById]
@Id int
AS
SELECT [Id],[Name],[Phone],[Mail],[IsDeleted] from [Client]
where [Id]=@Id 