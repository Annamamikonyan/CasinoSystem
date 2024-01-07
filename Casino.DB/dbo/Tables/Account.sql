CREATE TABLE [dbo].[Account] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [PlayerId]    INT          NOT NULL,
    [AccountType] TINYINT      NOT NULL,
    [Balance]     DECIMAL (18) NOT NULL,
    CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Account_PlayerId] FOREIGN KEY ([PlayerId]) REFERENCES [dbo].[Player] ([Id])
);

