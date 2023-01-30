CREATE TABLE [dbo].[Order] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [ClientId]    INT            NULL,
    [IsCompleted] BIT            DEFAULT ((0)) NULL,
    [Adress]      NVARCHAR (50)  NOT NULL,
    [Date]        DATE           NULL,
    [Cost]        INT            NULL,
    [Rate]        INT            NULL,
    [Report]      NVARCHAR (250) NULL,
    [IsDeleted]   BIT            DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([ClientId]) REFERENCES [dbo].[Client] ([Id]),
    FOREIGN KEY ([Rate]) REFERENCES [dbo].[Rate] ([Id])
);

