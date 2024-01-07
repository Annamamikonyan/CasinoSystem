CREATE TABLE [dbo].[Role] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [RoleName] VARCHAR (25) NOT NULL,
    CONSTRAINT [PK_CasinoRole] PRIMARY KEY CLUSTERED ([Id] ASC)
);

