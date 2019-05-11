CREATE TABLE [dbo].[Coupe] (
    [Id]              INT          NOT NULL,
    [aantal_stoelen]  INT          NOT NULL,
    [is_dubbeldekker] TINYINT      NOT NULL,
    [klasse_links]    VARCHAR (50) NOT NULL,
    [klasse_rechts]   VARCHAR (50) NOT NULL,
    [image]           BINARY (50)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

