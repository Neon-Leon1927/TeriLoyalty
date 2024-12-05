
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/05/2024 01:01:29
-- Generated from EDMX file: D:\Kity_tyan\StaDies\МДК 13.01\Дмитриев\TeriLoyalty\TeriLoyalty\TeriModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [teri];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_loyaltiesclients]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[clientsSet] DROP CONSTRAINT [FK_loyaltiesclients];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[clientsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[clientsSet];
GO
IF OBJECT_ID(N'[dbo].[loyaltiesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[loyaltiesSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'clientsSet'
CREATE TABLE [dbo].[clientsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [fio] nvarchar(max)  NOT NULL,
    [tel] nvarchar(max)  NOT NULL,
    [status] nvarchar(max)  NOT NULL,
    [bonus] int  NOT NULL,
    [loyalties_Id] int  NOT NULL
);
GO

-- Creating table 'loyaltiesSet'
CREATE TABLE [dbo].[loyaltiesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [loyalty] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'clientsSet'
ALTER TABLE [dbo].[clientsSet]
ADD CONSTRAINT [PK_clientsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'loyaltiesSet'
ALTER TABLE [dbo].[loyaltiesSet]
ADD CONSTRAINT [PK_loyaltiesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [loyalties_Id] in table 'clientsSet'
ALTER TABLE [dbo].[clientsSet]
ADD CONSTRAINT [FK_loyaltiesclients]
    FOREIGN KEY ([loyalties_Id])
    REFERENCES [dbo].[loyaltiesSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_loyaltiesclients'
CREATE INDEX [IX_FK_loyaltiesclients]
ON [dbo].[clientsSet]
    ([loyalties_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------