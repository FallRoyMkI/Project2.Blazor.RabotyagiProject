CREATE TABLE [dbo].[BusyTime] (
    [Id]          INT      IDENTITY (1, 1) NOT NULL,
    [StartTime]   TIME (7) NOT NULL,
    [EndTime]     TIME (7) NOT NULL,
    [TimetableId] INT      NOT NULL,
    [IsDeleted]   BIT      DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([TimetableId]) REFERENCES [dbo].[Timetable] ([Id])
);

