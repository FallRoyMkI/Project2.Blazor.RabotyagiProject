create procedure [dbo].[Client_GetAll]
As
Select [Id],[Name],[Phone],[Mail] from [Client] 
Where [IsDeleted] <> 1