
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/18/2017 15:48:26
-- Generated from EDMX file: E:\Rob\Dropbox\Prive van rob\School\HBO\2e leerjaar\PROG5\Prog5\Eindopdracht\Entities.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Entities];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Category]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Category];
GO
IF OBJECT_ID(N'[dbo].[Equipment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Equipment];
GO
IF OBJECT_ID(N'[dbo].[Inventory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Inventory];
GO
IF OBJECT_ID(N'[dbo].[Ninja]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ninja];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [Id] int  NOT NULL,
    [Name] varchar(255)  NOT NULL
);
GO

-- Creating table 'Equipments'
CREATE TABLE [dbo].[Equipments] (
    [Id] int  NOT NULL,
    [Category] nvarchar(max)  NOT NULL,
    [Name] varchar(255)  NOT NULL,
    [Price] int  NOT NULL,
    [Agility] int  NOT NULL,
    [Strenght] int  NOT NULL,
    [Intelligence] int  NOT NULL
);
GO

-- Creating table 'Ninjas'
CREATE TABLE [dbo].[Ninjas] (
    [Id] int  NOT NULL,
    [Name] varchar(255)  NOT NULL,
    [Currency] int  NOT NULL,
    [InventoryID] int  NOT NULL
);
GO

-- Creating table 'Inventories'
CREATE TABLE [dbo].[Inventories] (
    [Id] int  NOT NULL,
    [NinjaID] int  NOT NULL,
    [EquipmentID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Equipments'
ALTER TABLE [dbo].[Equipments]
ADD CONSTRAINT [PK_Equipments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Ninjas'
ALTER TABLE [dbo].[Ninjas]
ADD CONSTRAINT [PK_Ninjas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Inventories'
ALTER TABLE [dbo].[Inventories]
ADD CONSTRAINT [PK_Inventories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------