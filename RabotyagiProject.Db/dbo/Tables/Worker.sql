CREATE TABLE [dbo].[Worker] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (50) NOT NULL,
    [Phone]     NVARCHAR (11) NOT NULL,
    [Mail]      NVARCHAR (50) NOT NULL,
    [IsDeleted] BIT           DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Mail] ASC),
    UNIQUE NONCLUSTERED ([Phone] ASC)
);

