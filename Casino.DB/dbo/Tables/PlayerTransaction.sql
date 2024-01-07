CREATE TABLE [dbo].[PlayerTransaction] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [AccountId]     INT           NOT NULL,
    [OperationType] BIT           NOT NULL,
    [Amount]        DECIMAL (18)  NOT NULL,
    [CreationTime]  DATETIME2 (3) NOT NULL,
    CONSTRAINT [PK_PlayerTransaction] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Transaction_AccountId] FOREIGN KEY ([AccountId]) REFERENCES [dbo].[Account] ([Id])
);

