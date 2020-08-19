
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/19/2020 19:30:07
-- Generated from EDMX file: C:\dev\dayDBWeb\DbWebExample-master\CarWebApiServer\Models\CarsDataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DriversDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Cars]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cars];
GO
IF OBJECT_ID(N'[dbo].[CarSizes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CarSizes];
GO
IF OBJECT_ID(N'[dbo].[DriverLessonTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DriverLessonTypes];
GO
IF OBJECT_ID(N'[dbo].[Drivers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Drivers];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cars'
CREATE TABLE [dbo].[Cars] (
    [ID] int  NOT NULL,
    [CarSize] int  NOT NULL,
    [CarCompany] varchar(100)  NOT NULL,
    [CarColor] int  NULL,
    [Comments] varchar(100)  NOT NULL
);
GO

-- Creating table 'CarSizes'
CREATE TABLE [dbo].[CarSizes] (
    [ID] int  NOT NULL,
    [CarSize1] varchar(50)  NOT NULL,
    [NumOfPassengers] int  NULL
);
GO

-- Creating table 'DriverLessonType'
CREATE TABLE [dbo].[DriverLessonType] (
    [LessonType] int  NOT NULL,
    [LessonTypeDriver] nvarchar(50)  NULL
);
GO

-- Creating table 'Drivers'
CREATE TABLE [dbo].[Drivers] (
    [ID] int  NOT NULL,
    [DriverName] nvarchar(50)  NOT NULL,
    [Age] int  NULL,
    [Address] nvarchar(150)  NULL,
    [DriversLessonType] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [PK_Cars]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CarSizes'
ALTER TABLE [dbo].[CarSizes]
ADD CONSTRAINT [PK_CarSizes]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [LessonType] in table 'DriverLessonType'
ALTER TABLE [dbo].[DriverLessonType]
ADD CONSTRAINT [PK_DriverLessonType]
    PRIMARY KEY CLUSTERED ([LessonType] ASC);
GO

-- Creating primary key on [ID] in table 'Drivers'
ALTER TABLE [dbo].[Drivers]
ADD CONSTRAINT [PK_Drivers]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------