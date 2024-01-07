CREATE TABLE [dbo].[User] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Email]        NVARCHAR (50)  NOT NULL,
    [UserName]     VARCHAR (50)   NOT NULL,
    [PasswordHash] VARCHAR (150)  NOT NULL,
    [Salt]         INT            NOT NULL,
    [FirstName]    NVARCHAR (255) NULL,
    [LastName]     NVARCHAR (255) NULL,
    [MobileNumber] VARCHAR (50)   NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([Id] ASC)
);

