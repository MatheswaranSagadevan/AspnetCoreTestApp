IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Property] (
    [Id] uniqueidentifier NOT NULL,
    [Address] nvarchar(max) NULL,
    [YearBuild] smallint NOT NULL,
    [ListPrice] float NOT NULL,
    [MonthlyRent] float NOT NULL,
    [GrossYield] real NOT NULL,
    CONSTRAINT [PK_Property] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200731120900_MyInitialMigration', N'3.1.6');

GO

