
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/17/2020 15:11:51
-- Generated from EDMX file: D:\entityframework\ModelFirstApproach\ModelFirstApproach2\ModelFirstApproach2\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [anil];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Companies'
CREATE TABLE [dbo].[Companies] (
    [Cid] int IDENTITY(1,1) NOT NULL primary key,
    [Cname] nvarchar(max)  NOT NULL,
    [Clocation] nvarchar(max)  NOT NULL,
    [Bid] int  NOT NULL constraint fk_pp foreign key references Bikes(Bid)
);
GO

-- Creating table 'Bikes'
CREATE TABLE [dbo].[Bikes] (
    [Bid] int IDENTITY(1,1) NOT NULL primary key,
    [Bname] nvarchar(max)  NOT NULL,
    [Bmodel] nvarchar(max)  NOT NULL,
    [Bprice] float  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Cid] in table 'Companies'
ALTER TABLE [dbo].[Companies]
ADD CONSTRAINT [PK_Companies]
    PRIMARY KEY CLUSTERED ([Cid] ASC);
GO

-- Creating primary key on [Bid] in table 'Bikes'
ALTER TABLE [dbo].[Bikes]
ADD CONSTRAINT [PK_Bikes]
    PRIMARY KEY CLUSTERED ([Bid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------