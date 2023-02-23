CREATE PROCEDURE [dbo].[Worker_GetAllServicesByWorkerId]
@Id int
AS
Select S.[Id], S.[Type], WS.[Cost] from [Worker_Service] AS WS
LEFT JOIN [dbo].[Service] AS S ON WS.[ServiceId] = S.[Id]
Where [WorkerId] = @Id and WS.[IsDeleted] <> 1 and S.[IsDeleted] <> 1
