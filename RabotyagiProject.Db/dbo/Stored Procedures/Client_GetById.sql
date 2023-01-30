CREATE PROCEDURE [dbo].[Client_GetById]
@Id int
AS
SELECT [Name],[Phone],[Mail],[IsDeleted] from [Client]
where [Id]=@Id