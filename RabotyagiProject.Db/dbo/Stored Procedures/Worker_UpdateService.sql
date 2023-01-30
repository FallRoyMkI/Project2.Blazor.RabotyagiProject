CREATE PROCEDURE [dbo].[Worker_UpdateService]
@WorkerId int,
@ServiceId int,
@Cost int,
@IsDeleted bit
AS
Update [Worker_Service]
Set [Cost] = @Cost, [IsDeleted] = @IsDeleted
Where [WorkerId] = @WorkerId and [ServiceId] = @ServiceId