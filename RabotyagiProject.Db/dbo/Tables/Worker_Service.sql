CREATE TABLE [dbo].[Worker_Service] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [WorkerId]  INT NOT NULL,
    [ServiceId] INT NOT NULL,
    [Cost]      INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([ServiceId]) REFERENCES [dbo].[Service] ([Id]),
    FOREIGN KEY ([WorkerId]) REFERENCES [dbo].[Worker] ([Id])
);

