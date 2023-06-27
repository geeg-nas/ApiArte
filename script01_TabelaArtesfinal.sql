IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Artes] (
    [Id] int NOT NULL IDENTITY,
    [Titulo] nvarchar(max) NOT NULL,
    [Categoria] nvarchar(max) NOT NULL,
    [Artista] nvarchar(max) NOT NULL,
    [Data] int NOT NULL,
    [Descricao] nvarchar(max) NOT NULL,
    [Localizacao] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Artes] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Artista', N'Categoria', N'Data', N'Descricao', N'Localizacao', N'Titulo') AND [object_id] = OBJECT_ID(N'[Artes]'))
    SET IDENTITY_INSERT [Artes] ON;
INSERT INTO [Artes] ([Id], [Artista], [Categoria], [Data], [Descricao], [Localizacao], [Titulo])
VALUES (1, N'Leonardo da Vinci', N'Pintura', 1503, N'Mona Lisa também conhecida como A Gioconda ou ainda Mona Lisa del Giocondo é a mais notável e conhecida obra de Leonardo da Vinci', N'Museu lo Louvre', N'Monalisa'),
(2, N'Arthur Sasse', N'Fotográfia', 1951, N'Uma das imagens mais conhecidas da história é a do físico Albert Einstein mostrando a língua.', N'indefinida', N'Einstein mostrando a língua'),
(3, N'Leonardo da Vinci', N'Pintura', 1503, N'Mona Lisa também conhecida como A Gioconda ou ainda Mona Lisa del Giocondo é a mais notável e conhecida obra de Leonardo da Vinci', N'Museu lo Louvre', N'Monalisa'),
(4, N'Leonardo da Vinci', N'Pintura', 1503, N'Mona Lisa também conhecida como A Gioconda ou ainda Mona Lisa del Giocondo é a mais notável e conhecida obra de Leonardo da Vinci', N'Museu lo Louvre', N'Monalisa'),
(5, N'Leonardo da Vinci', N'Pintura', 1503, N'Mona Lisa também conhecida como A Gioconda ou ainda Mona Lisa del Giocondo é a mais notável e conhecida obra de Leonardo da Vinci', N'Museu lo Louvre', N'Monalisa'),
(6, N'Leonardo da Vinci', N'Pintura', 1503, N'Mona Lisa também conhecida como A Gioconda ou ainda Mona Lisa del Giocondo é a mais notável e conhecida obra de Leonardo da Vinci', N'Museu lo Louvre', N'Monalisa');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Artista', N'Categoria', N'Data', N'Descricao', N'Localizacao', N'Titulo') AND [object_id] = OBJECT_ID(N'[Artes]'))
    SET IDENTITY_INSERT [Artes] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230620231757_InitialCreate', N'7.0.7');
GO

COMMIT;
GO

