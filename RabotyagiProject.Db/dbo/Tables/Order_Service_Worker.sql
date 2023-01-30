CREATE TABLE [dbo].[Order_Service_Worker] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [OrderId]   INT NOT NULL,
    [ServiceId] INT NOT NULL,
    [WorkerId]  INT NULL,
    [Workload]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Order] ([Id]),
    FOREIGN KEY ([ServiceId]) REFERENCES [dbo].[Service] ([Id]),
    FOREIGN KEY ([WorkerId]) REFERENCES [dbo].[Worker] ([Id])
);

