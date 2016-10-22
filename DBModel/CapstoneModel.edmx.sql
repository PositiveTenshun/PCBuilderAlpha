
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/19/2016 01:11:28
-- Generated from EDMX file: C:\Users\Scott Hache\Source\Workspaces\PCBuilder\PCBuilder\DBModel\CapstoneModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CapstoneDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ComponentBuild_Component]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ComponentBuild] DROP CONSTRAINT [FK_ComponentBuild_Component];
GO
IF OBJECT_ID(N'[dbo].[FK_ComponentBuild_Build]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ComponentBuild] DROP CONSTRAINT [FK_ComponentBuild_Build];
GO
IF OBJECT_ID(N'[dbo].[FK_Accessory_inherits_Component]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Components_Accessory] DROP CONSTRAINT [FK_Accessory_inherits_Component];
GO
IF OBJECT_ID(N'[dbo].[FK_Case_inherits_Component]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Components_Case] DROP CONSTRAINT [FK_Case_inherits_Component];
GO
IF OBJECT_ID(N'[dbo].[FK_PowerSupply_inherits_Component]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Components_PowerSupply] DROP CONSTRAINT [FK_PowerSupply_inherits_Component];
GO
IF OBJECT_ID(N'[dbo].[FK_Motherboard_inherits_Component]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Components_Motherboard] DROP CONSTRAINT [FK_Motherboard_inherits_Component];
GO
IF OBJECT_ID(N'[dbo].[FK_Processor_inherits_Component]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Components_Processor] DROP CONSTRAINT [FK_Processor_inherits_Component];
GO
IF OBJECT_ID(N'[dbo].[FK_Monitor_inherits_Component]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Components_Monitor] DROP CONSTRAINT [FK_Monitor_inherits_Component];
GO
IF OBJECT_ID(N'[dbo].[FK_HardDrive_inherits_Component]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Components_HardDrive] DROP CONSTRAINT [FK_HardDrive_inherits_Component];
GO
IF OBJECT_ID(N'[dbo].[FK_RAM_inherits_Component]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Components_RAM] DROP CONSTRAINT [FK_RAM_inherits_Component];
GO
IF OBJECT_ID(N'[dbo].[FK_GraphicsCard_inherits_Component]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Components_GraphicsCard] DROP CONSTRAINT [FK_GraphicsCard_inherits_Component];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Components]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Components];
GO
IF OBJECT_ID(N'[dbo].[Builds]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Builds];
GO
IF OBJECT_ID(N'[dbo].[Components_Accessory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Components_Accessory];
GO
IF OBJECT_ID(N'[dbo].[Components_Case]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Components_Case];
GO
IF OBJECT_ID(N'[dbo].[Components_PowerSupply]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Components_PowerSupply];
GO
IF OBJECT_ID(N'[dbo].[Components_Motherboard]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Components_Motherboard];
GO
IF OBJECT_ID(N'[dbo].[Components_Processor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Components_Processor];
GO
IF OBJECT_ID(N'[dbo].[Components_Monitor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Components_Monitor];
GO
IF OBJECT_ID(N'[dbo].[Components_HardDrive]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Components_HardDrive];
GO
IF OBJECT_ID(N'[dbo].[Components_RAM]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Components_RAM];
GO
IF OBJECT_ID(N'[dbo].[Components_GraphicsCard]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Components_GraphicsCard];
GO
IF OBJECT_ID(N'[dbo].[ComponentBuild]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ComponentBuild];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Components'
CREATE TABLE [dbo].[Components] (
    [ComponentId] int IDENTITY(1,1) NOT NULL,
    [Brand] nvarchar(max)  NOT NULL,
    [ModelNumber] nvarchar(max)  NOT NULL,
    [ModelName] nvarchar(max)  NOT NULL,
    [Rating] nvarchar(max)  NOT NULL,
    [ProductCode] nvarchar(max)  NOT NULL,
    [Price] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Builds'
CREATE TABLE [dbo].[Builds] (
    [BuildId] int IDENTITY(1,1) NOT NULL,
    [BuildName] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Rating] nvarchar(max)  NOT NULL,
    [TotalPrice] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Components_Accessory'
CREATE TABLE [dbo].[Components_Accessory] (
    [AccessoryId] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [ConnectionType] nvarchar(max)  NOT NULL,
    [Features] nvarchar(max)  NOT NULL,
    [ComponentId] int  NOT NULL
);
GO

-- Creating table 'Components_Case'
CREATE TABLE [dbo].[Components_Case] (
    [CaseId] int IDENTITY(1,1) NOT NULL,
    [Fans] nvarchar(max)  NOT NULL,
    [Size] nvarchar(max)  NOT NULL,
    [ComponentId] int  NOT NULL
);
GO

-- Creating table 'Components_PowerSupply'
CREATE TABLE [dbo].[Components_PowerSupply] (
    [PowerSupplyId] int IDENTITY(1,1) NOT NULL,
    [Wattage] nvarchar(max)  NOT NULL,
    [Connections] nvarchar(max)  NOT NULL,
    [ComponentId] int  NOT NULL
);
GO

-- Creating table 'Components_Motherboard'
CREATE TABLE [dbo].[Components_Motherboard] (
    [MotherboardId] int IDENTITY(1,1) NOT NULL,
    [Pins] nvarchar(max)  NOT NULL,
    [PCISlots] nvarchar(max)  NOT NULL,
    [Connectors] nvarchar(max)  NOT NULL,
    [Chips] nvarchar(max)  NOT NULL,
    [MemorySlots] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [ComponentId] int  NOT NULL
);
GO

-- Creating table 'Components_Processor'
CREATE TABLE [dbo].[Components_Processor] (
    [ProcessorId] int IDENTITY(1,1) NOT NULL,
    [Speed] nvarchar(max)  NOT NULL,
    [Memory] nvarchar(max)  NOT NULL,
    [Pins] nvarchar(max)  NOT NULL,
    [ComponentId] int  NOT NULL
);
GO

-- Creating table 'Components_Monitor'
CREATE TABLE [dbo].[Components_Monitor] (
    [MonitorId] int IDENTITY(1,1) NOT NULL,
    [Size] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Latency] nvarchar(max)  NOT NULL,
    [HasSpeakers] nvarchar(max)  NOT NULL,
    [ComponentId] int  NOT NULL
);
GO

-- Creating table 'Components_HardDrive'
CREATE TABLE [dbo].[Components_HardDrive] (
    [HardDriveId] int IDENTITY(1,1) NOT NULL,
    [Capacity] nvarchar(max)  NOT NULL,
    [IsSSD] nvarchar(max)  NOT NULL,
    [ComponentId] int  NOT NULL
);
GO

-- Creating table 'Components_RAM'
CREATE TABLE [dbo].[Components_RAM] (
    [RAMId] int IDENTITY(1,1) NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Memory] nvarchar(max)  NOT NULL,
    [ComponentId] int  NOT NULL
);
GO

-- Creating table 'Components_GraphicsCard'
CREATE TABLE [dbo].[Components_GraphicsCard] (
    [GraphicsCardId] int IDENTITY(1,1) NOT NULL,
    [GRAM] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Speed] nvarchar(max)  NOT NULL,
    [ComponentId] int  NOT NULL
);
GO

-- Creating table 'ComponentBuild'
CREATE TABLE [dbo].[ComponentBuild] (
    [Components_ComponentId] int  NOT NULL,
    [Builds_BuildId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ComponentId] in table 'Components'
ALTER TABLE [dbo].[Components]
ADD CONSTRAINT [PK_Components]
    PRIMARY KEY CLUSTERED ([ComponentId] ASC);
GO

-- Creating primary key on [BuildId] in table 'Builds'
ALTER TABLE [dbo].[Builds]
ADD CONSTRAINT [PK_Builds]
    PRIMARY KEY CLUSTERED ([BuildId] ASC);
GO

-- Creating primary key on [ComponentId] in table 'Components_Accessory'
ALTER TABLE [dbo].[Components_Accessory]
ADD CONSTRAINT [PK_Components_Accessory]
    PRIMARY KEY CLUSTERED ([ComponentId] ASC);
GO

-- Creating primary key on [ComponentId] in table 'Components_Case'
ALTER TABLE [dbo].[Components_Case]
ADD CONSTRAINT [PK_Components_Case]
    PRIMARY KEY CLUSTERED ([ComponentId] ASC);
GO

-- Creating primary key on [ComponentId] in table 'Components_PowerSupply'
ALTER TABLE [dbo].[Components_PowerSupply]
ADD CONSTRAINT [PK_Components_PowerSupply]
    PRIMARY KEY CLUSTERED ([ComponentId] ASC);
GO

-- Creating primary key on [ComponentId] in table 'Components_Motherboard'
ALTER TABLE [dbo].[Components_Motherboard]
ADD CONSTRAINT [PK_Components_Motherboard]
    PRIMARY KEY CLUSTERED ([ComponentId] ASC);
GO

-- Creating primary key on [ComponentId] in table 'Components_Processor'
ALTER TABLE [dbo].[Components_Processor]
ADD CONSTRAINT [PK_Components_Processor]
    PRIMARY KEY CLUSTERED ([ComponentId] ASC);
GO

-- Creating primary key on [ComponentId] in table 'Components_Monitor'
ALTER TABLE [dbo].[Components_Monitor]
ADD CONSTRAINT [PK_Components_Monitor]
    PRIMARY KEY CLUSTERED ([ComponentId] ASC);
GO

-- Creating primary key on [ComponentId] in table 'Components_HardDrive'
ALTER TABLE [dbo].[Components_HardDrive]
ADD CONSTRAINT [PK_Components_HardDrive]
    PRIMARY KEY CLUSTERED ([ComponentId] ASC);
GO

-- Creating primary key on [ComponentId] in table 'Components_RAM'
ALTER TABLE [dbo].[Components_RAM]
ADD CONSTRAINT [PK_Components_RAM]
    PRIMARY KEY CLUSTERED ([ComponentId] ASC);
GO

-- Creating primary key on [ComponentId] in table 'Components_GraphicsCard'
ALTER TABLE [dbo].[Components_GraphicsCard]
ADD CONSTRAINT [PK_Components_GraphicsCard]
    PRIMARY KEY CLUSTERED ([ComponentId] ASC);
GO

-- Creating primary key on [Components_ComponentId], [Builds_BuildId] in table 'ComponentBuild'
ALTER TABLE [dbo].[ComponentBuild]
ADD CONSTRAINT [PK_ComponentBuild]
    PRIMARY KEY CLUSTERED ([Components_ComponentId], [Builds_BuildId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Components_ComponentId] in table 'ComponentBuild'
ALTER TABLE [dbo].[ComponentBuild]
ADD CONSTRAINT [FK_ComponentBuild_Component]
    FOREIGN KEY ([Components_ComponentId])
    REFERENCES [dbo].[Components]
        ([ComponentId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Builds_BuildId] in table 'ComponentBuild'
ALTER TABLE [dbo].[ComponentBuild]
ADD CONSTRAINT [FK_ComponentBuild_Build]
    FOREIGN KEY ([Builds_BuildId])
    REFERENCES [dbo].[Builds]
        ([BuildId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComponentBuild_Build'
CREATE INDEX [IX_FK_ComponentBuild_Build]
ON [dbo].[ComponentBuild]
    ([Builds_BuildId]);
GO

-- Creating foreign key on [ComponentId] in table 'Components_Accessory'
ALTER TABLE [dbo].[Components_Accessory]
ADD CONSTRAINT [FK_Accessory_inherits_Component]
    FOREIGN KEY ([ComponentId])
    REFERENCES [dbo].[Components]
        ([ComponentId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ComponentId] in table 'Components_Case'
ALTER TABLE [dbo].[Components_Case]
ADD CONSTRAINT [FK_Case_inherits_Component]
    FOREIGN KEY ([ComponentId])
    REFERENCES [dbo].[Components]
        ([ComponentId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ComponentId] in table 'Components_PowerSupply'
ALTER TABLE [dbo].[Components_PowerSupply]
ADD CONSTRAINT [FK_PowerSupply_inherits_Component]
    FOREIGN KEY ([ComponentId])
    REFERENCES [dbo].[Components]
        ([ComponentId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ComponentId] in table 'Components_Motherboard'
ALTER TABLE [dbo].[Components_Motherboard]
ADD CONSTRAINT [FK_Motherboard_inherits_Component]
    FOREIGN KEY ([ComponentId])
    REFERENCES [dbo].[Components]
        ([ComponentId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ComponentId] in table 'Components_Processor'
ALTER TABLE [dbo].[Components_Processor]
ADD CONSTRAINT [FK_Processor_inherits_Component]
    FOREIGN KEY ([ComponentId])
    REFERENCES [dbo].[Components]
        ([ComponentId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ComponentId] in table 'Components_Monitor'
ALTER TABLE [dbo].[Components_Monitor]
ADD CONSTRAINT [FK_Monitor_inherits_Component]
    FOREIGN KEY ([ComponentId])
    REFERENCES [dbo].[Components]
        ([ComponentId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ComponentId] in table 'Components_HardDrive'
ALTER TABLE [dbo].[Components_HardDrive]
ADD CONSTRAINT [FK_HardDrive_inherits_Component]
    FOREIGN KEY ([ComponentId])
    REFERENCES [dbo].[Components]
        ([ComponentId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ComponentId] in table 'Components_RAM'
ALTER TABLE [dbo].[Components_RAM]
ADD CONSTRAINT [FK_RAM_inherits_Component]
    FOREIGN KEY ([ComponentId])
    REFERENCES [dbo].[Components]
        ([ComponentId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ComponentId] in table 'Components_GraphicsCard'
ALTER TABLE [dbo].[Components_GraphicsCard]
ADD CONSTRAINT [FK_GraphicsCard_inherits_Component]
    FOREIGN KEY ([ComponentId])
    REFERENCES [dbo].[Components]
        ([ComponentId])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------