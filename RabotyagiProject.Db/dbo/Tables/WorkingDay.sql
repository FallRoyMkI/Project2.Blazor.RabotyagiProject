﻿CREATE TABLE [dbo].[WorkingDay] (
    [Id]   INT  IDENTITY (1, 1) NOT NULL,
    [Date] DATE NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Date] ASC)
);

