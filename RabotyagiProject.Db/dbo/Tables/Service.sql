CREATE TABLE [dbo].[Service] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Type]      NVARCHAR (50) NOT NULL,
    [IsDeleted] BIT           DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Type] ASC)
);

