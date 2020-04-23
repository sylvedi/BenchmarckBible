CREATE TABLE [dbo].[Books] (
    [id]        INT            IDENTITY (1, 1) NOT NULL,
    [testament] NVARCHAR (MAX) NULL,
    [book]      NVARCHAR (MAX) NOT NULL,
    [verse]     INT            NOT NULL,
    [chapter]   INT            NOT NULL,
    [vtext]     NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Books] PRIMARY KEY CLUSTERED ([id] ASC)
);

