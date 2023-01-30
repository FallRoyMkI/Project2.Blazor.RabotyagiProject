CREATE PROCEDURE AddWorker
(
@Name NVARCHAR(50),
@Phone NVARCHAR(11),
@Mail NVARCHAR(50)
)
AS
INSERT INTO [Worker] ([Name],[Phone],[Mail])
VALUES (@Name, @Phone, @Mail)


