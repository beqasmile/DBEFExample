
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/26/2020 20:14:47
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

IF OBJECT_ID(N'[dbo].[Car]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Car];
GO
IF OBJECT_ID(N'[dbo].[CarSize]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CarSize];
GO
IF OBJECT_ID(N'[dbo].[DriverLessonType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DriverLessonType];
GO
IF OBJECT_ID(N'[dbo].[Drivers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Drivers];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Car'
CREATE TABLE [dbo].[Car] (
    [ID] int  NOT NULL,
    [CarSize] int  NOT NULL,
    [CarCompany] varchar(100)  NOT NULL,
    [CarColor] int  NULL,
    [Comments] varchar(100)  NOT NULL
);
GO

-- Creating table 'CarSize'
CREATE TABLE [dbo].[CarSize] (
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

-- Creating table 'Roads'
CREATE TABLE [dbo].[Roads] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RoadName] nvarchar(max)  NOT NULL,
    [MaxSpeed] int  NOT NULL,
    [NumLanes] int  NULL,
    [RoadDesc] nvarchar(max)  NULL,
    [RoadNum] smallint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Car'
ALTER TABLE [dbo].[Car]
ADD CONSTRAINT [PK_Car]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CarSize'
ALTER TABLE [dbo].[CarSize]
ADD CONSTRAINT [PK_CarSize]
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

-- Creating primary key on [Id] in table 'Roads'
ALTER TABLE [dbo].[Roads]
ADD CONSTRAINT [PK_Roads]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------