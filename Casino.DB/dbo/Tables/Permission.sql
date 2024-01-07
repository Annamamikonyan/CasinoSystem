CREATE TABLE [dbo].[Permission] (
    [Id]   INT          IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (25) NOT NULL,
    CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED ([Id] ASC)
);

