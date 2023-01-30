CREATE TABLE [dbo].[Timetable] (
    [Id]           INT IDENTITY (1, 1) NOT NULL,
    [WorkerId]     INT NULL,
    [WorkingDayId] INT NULL,
    [IsDeleted]    BIT DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([WorkerId]) REFERENCES [dbo].[Worker] ([Id]),
    FOREIGN KEY ([WorkingDayId]) REFERENCES [dbo].[WorkingDay] ([Id])
);

