CREATE PROCEDURE [dbo].[Order_Service_Worker_DeleteById]
	@Id int
AS
DELETE [Order_Service_Worker]
WHERE [Id]=@Id