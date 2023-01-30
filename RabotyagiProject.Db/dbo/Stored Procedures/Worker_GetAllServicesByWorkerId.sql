CREATE PROCEDURE [dbo].[Worker_GetAllServicesByWorkerId]
@Id int
AS
Select s.[Id], S.[Type], WS.[Cost] from [dbo].[Worker_Service] as WS
INNER JOIN [dbo].[Service] as S on WS.ServiceId = S.Id
Where WS.[WorkerId] = @Id
