
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/09/2018 18:44:46
-- Generated from EDMX file: D:\PTO\NarGestionDistribuidora_actualizando_VS2015GLORIA\CapaDatafirst\ModelDataFirst.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BDGLORIA260218];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[NARGESTModelStoreContainer].[FK_MOVIDET_MOVICAB]', 'F') IS NOT NULL
    ALTER TABLE [NARGESTModelStoreContainer].[MOVIDET] DROP CONSTRAINT [FK_MOVIDET_MOVICAB];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[MOVICAB]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MOVICAB];
GO
IF OBJECT_ID(N'[dbo].[VENTA_X_COBRAR]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VENTA_X_COBRAR];
GO
IF OBJECT_ID(N'[NARGESTModelStoreContainer].[MOVIDET]', 'U') IS NOT NULL
    DROP TABLE [NARGESTModelStoreContainer].[MOVIDET];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'VENTA_X_COBRAR'
CREATE TABLE [dbo].[VENTA_X_COBRAR] (
    [CDTIPODOCUM] varchar(20)  NOT NULL,
    [NRODOCU] decimal(10,0)  NOT NULL,
    [CDMONEDA] char(2)  NOT NULL,
    [CDCLIENTE] varchar(20)  NULL,
    [TOTCREDBAS] decimal(20,4)  NOT NULL,
    [TOTCREDEXT] decimal(20,4)  NOT NULL,
    [FECDOCUM] datetime  NOT NULL,
    [PLAZO] decimal(10,0)  NULL,
    [VENCIMIENTO] datetime  NOT NULL,
    [ESTADO] char(20)  NULL,
    [PAGCREDBAS] decimal(20,4)  NULL,
    [PAGCREDEXT] decimal(20,4)  NULL,
    [TIPCREDFAC] char(3)  NULL,
    [TRANS] bit  NULL,
    [DATETRANS] datetime  NULL,
    [CODEMPRESA] varchar(10)  NULL,
    [CDCLIENTEDEP] varchar(20)  NULL,
    [PTOVTA] varchar(50)  NULL,
    [DOCUREF] varchar(50)  NULL,
    [fproceso] datetime  NULL,
    [PAG] bit  NULL,
    [DSCLIENTE] varchar(50)  NULL,
    [EXISTE] varchar(50)  NULL,
    [marca] bit  NULL,
    [PPAGO] decimal(20,4)  NULL,
    [codvend] nvarchar(50)  NULL
);
GO

-- Creating table 'MOVICAB'
CREATE TABLE [dbo].[MOVICAB] (
    [CODEMPRESA] varchar(10)  NULL,
    [NROMOVI] decimal(12,0)  NOT NULL,
    [CDALMACEN] char(5)  NOT NULL,
    [CDTIPOMOV] char(5)  NOT NULL,
    [CDPROVEE] char(20)  NULL,
    [CDTIPODOC] char(3)  NOT NULL,
    [INOUT] int  NULL,
    [NRODOC] char(15)  NOT NULL,
    [FECDOCUM] datetime  NOT NULL,
    [FECPROCESO] datetime  NOT NULL,
    [ESTADO] char(1)  NOT NULL,
    [CDMONEDA] char(2)  NULL,
    [SUBTOTBAS] decimal(20,4)  NOT NULL,
    [SUBTOTEXT] decimal(20,4)  NOT NULL,
    [CAMBIO] decimal(6,4)  NULL,
    [IGVBAS] decimal(20,4)  NOT NULL,
    [IGVEXT] decimal(20,4)  NOT NULL,
    [TOTBAS] decimal(20,4)  NOT NULL,
    [TOTEXT] decimal(20,4)  NOT NULL,
    [PORCENDESC] decimal(20,4)  NOT NULL,
    [MONTODESCBAS] decimal(20,4)  NOT NULL,
    [MONTODESCEXT] decimal(20,4)  NOT NULL,
    [ALMATRAN] char(5)  NULL,
    [USERID] char(20)  NOT NULL,
    [PERIODO] varchar(15)  NULL,
    [EJERCICIO] varchar(4)  NULL,
    [TSTAMP] binary(8)  NULL,
    [DATETRANS] datetime  NULL,
    [OBS] varchar(50)  NULL,
    [cdalmacensal] char(5)  NULL,
    [CRED] bit  NULL,
    [tipocred] varchar(20)  NULL,
    [PTOVTA] char(10)  NULL,
    [FLETE] decimal(20,4)  NOT NULL,
    [TRANS] bit  NOT NULL,
    [PERCEPCION] decimal(20,4)  NULL,
    [DETRACCION] decimal(20,4)  NULL,
    [FECHARECEPC] datetime  NULL,
    [INOUT2] int  NULL,
    [text1] varchar(50)  NULL,
    [text2] varchar(50)  NULL,
    [text3] varchar(50)  NULL,
    [cost] bit  NULL
);
GO

-- Creating table 'MOVIDET'
CREATE TABLE [dbo].[MOVIDET] (
    [CODEMPRESA] varchar(10)  NULL,
    [NROMOVI] decimal(12,0)  NOT NULL,
    [CDTIPOMOV] char(5)  NOT NULL,
    [CDALMACEN] char(5)  NOT NULL,
    [ITEM] smallint  NOT NULL,
    [CDARTICULO] varchar(20)  NULL,
    [CODPRES] varchar(4)  NULL,
    [CANTIDAD] decimal(20,4)  NOT NULL,
    [PORCIGV] decimal(20,5)  NULL,
    [COSTOBAS] decimal(20,5)  NOT NULL,
    [COSTOEXT] decimal(20,5)  NOT NULL,
    [SUBTOTBAS] decimal(20,4)  NOT NULL,
    [SUBTOTEXT] decimal(20,4)  NOT NULL,
    [FECDOCUM] datetime  NULL,
    [FECPROCESO] datetime  NULL,
    [INOUT] int  NULL,
    [USUARIO] char(20)  NULL,
    [TSTAMP] varchar(50)  NULL,
    [DATETRANS] datetime  NULL,
    [ESTADO] varchar(1)  NOT NULL,
    [PORCENDESC] decimal(20,4)  NOT NULL,
    [MONTODESCBAS] decimal(20,4)  NOT NULL,
    [MONTODESCEXT] decimal(20,4)  NOT NULL,
    [cost] bit  NULL,
    [GLOSA] varchar(50)  NULL,
    [CU] varchar(50)  NULL,
    [LOTE] varchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CDTIPODOCUM], [NRODOCU] in table 'VENTA_X_COBRAR'
ALTER TABLE [dbo].[VENTA_X_COBRAR]
ADD CONSTRAINT [PK_VENTA_X_COBRAR]
    PRIMARY KEY CLUSTERED ([CDTIPODOCUM], [NRODOCU] ASC);
GO

-- Creating primary key on [NROMOVI] in table 'MOVICAB'
ALTER TABLE [dbo].[MOVICAB]
ADD CONSTRAINT [PK_MOVICAB]
    PRIMARY KEY CLUSTERED ([NROMOVI] ASC);
GO

-- Creating primary key on [NROMOVI], [CDTIPOMOV], [CDALMACEN], [ITEM], [CANTIDAD], [COSTOBAS], [COSTOEXT], [SUBTOTBAS], [SUBTOTEXT], [ESTADO], [PORCENDESC], [MONTODESCBAS], [MONTODESCEXT] in table 'MOVIDET'
ALTER TABLE [dbo].[MOVIDET]
ADD CONSTRAINT [PK_MOVIDET]
    PRIMARY KEY CLUSTERED ([NROMOVI], [CDTIPOMOV], [CDALMACEN], [ITEM], [CANTIDAD], [COSTOBAS], [COSTOEXT], [SUBTOTBAS], [SUBTOTEXT], [ESTADO], [PORCENDESC], [MONTODESCBAS], [MONTODESCEXT] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [NROMOVI] in table 'MOVIDET'
ALTER TABLE [dbo].[MOVIDET]
ADD CONSTRAINT [FK_MOVIDET_MOVICAB]
    FOREIGN KEY ([NROMOVI])
    REFERENCES [dbo].[MOVICAB]
        ([NROMOVI])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------