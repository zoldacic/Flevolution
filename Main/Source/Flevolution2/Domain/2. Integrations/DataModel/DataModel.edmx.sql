
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 03/11/2013 12:58:51
-- Generated from EDMX file: C:\SrcP\Flevolution-TFS\Main\Source\Flevolution\WorkerRole\Infrastructure\DataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [[FlevolutionDB]]];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Areas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Areas];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Areas'
CREATE TABLE [dbo].[Areas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NoOfHouses] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ScoreboardSet'
CREATE TABLE [dbo].[ScoreboardSet] (
    [Id] int  NOT NULL,
    [Score] int  NOT NULL,
    [Session_Id] int  NOT NULL
);
GO

-- Creating table 'Players'
CREATE TABLE [dbo].[Players] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Sessions'
CREATE TABLE [dbo].[Sessions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StartDateTime] datetime  NOT NULL,
    [EndDateTime] datetime  NOT NULL
);
GO

-- Creating table 'PlayerHousesSet'
CREATE TABLE [dbo].[PlayerHousesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NoOfHouses] int  NOT NULL,
    [Player_Id] int  NOT NULL,
    [Area_Id] int  NOT NULL,
    [Session_Id] int  NOT NULL
);
GO

-- Creating table 'ScoreboardPlayer'
CREATE TABLE [dbo].[ScoreboardPlayer] (
    [Scoreboard_Id] int  NOT NULL,
    [Player_Id] int  NOT NULL
);
GO

-- Creating table 'SessionPlayer'
CREATE TABLE [dbo].[SessionPlayer] (
    [Session_Id] int  NOT NULL,
    [Player_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Areas'
ALTER TABLE [dbo].[Areas]
ADD CONSTRAINT [PK_Areas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ScoreboardSet'
ALTER TABLE [dbo].[ScoreboardSet]
ADD CONSTRAINT [PK_ScoreboardSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Players'
ALTER TABLE [dbo].[Players]
ADD CONSTRAINT [PK_Players]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sessions'
ALTER TABLE [dbo].[Sessions]
ADD CONSTRAINT [PK_Sessions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PlayerHousesSet'
ALTER TABLE [dbo].[PlayerHousesSet]
ADD CONSTRAINT [PK_PlayerHousesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Scoreboard_Id], [Player_Id] in table 'ScoreboardPlayer'
ALTER TABLE [dbo].[ScoreboardPlayer]
ADD CONSTRAINT [PK_ScoreboardPlayer]
    PRIMARY KEY NONCLUSTERED ([Scoreboard_Id], [Player_Id] ASC);
GO

-- Creating primary key on [Session_Id], [Player_Id] in table 'SessionPlayer'
ALTER TABLE [dbo].[SessionPlayer]
ADD CONSTRAINT [PK_SessionPlayer]
    PRIMARY KEY NONCLUSTERED ([Session_Id], [Player_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Scoreboard_Id] in table 'ScoreboardPlayer'
ALTER TABLE [dbo].[ScoreboardPlayer]
ADD CONSTRAINT [FK_ScoreboardPlayer_Scoreboard]
    FOREIGN KEY ([Scoreboard_Id])
    REFERENCES [dbo].[ScoreboardSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Player_Id] in table 'ScoreboardPlayer'
ALTER TABLE [dbo].[ScoreboardPlayer]
ADD CONSTRAINT [FK_ScoreboardPlayer_Player]
    FOREIGN KEY ([Player_Id])
    REFERENCES [dbo].[Players]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ScoreboardPlayer_Player'
CREATE INDEX [IX_FK_ScoreboardPlayer_Player]
ON [dbo].[ScoreboardPlayer]
    ([Player_Id]);
GO

-- Creating foreign key on [Session_Id] in table 'SessionPlayer'
ALTER TABLE [dbo].[SessionPlayer]
ADD CONSTRAINT [FK_SessionPlayer_Session]
    FOREIGN KEY ([Session_Id])
    REFERENCES [dbo].[Sessions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Player_Id] in table 'SessionPlayer'
ALTER TABLE [dbo].[SessionPlayer]
ADD CONSTRAINT [FK_SessionPlayer_Player]
    FOREIGN KEY ([Player_Id])
    REFERENCES [dbo].[Players]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SessionPlayer_Player'
CREATE INDEX [IX_FK_SessionPlayer_Player]
ON [dbo].[SessionPlayer]
    ([Player_Id]);
GO

-- Creating foreign key on [Session_Id] in table 'ScoreboardSet'
ALTER TABLE [dbo].[ScoreboardSet]
ADD CONSTRAINT [FK_ScoreboardSession]
    FOREIGN KEY ([Session_Id])
    REFERENCES [dbo].[Sessions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ScoreboardSession'
CREATE INDEX [IX_FK_ScoreboardSession]
ON [dbo].[ScoreboardSet]
    ([Session_Id]);
GO

-- Creating foreign key on [Player_Id] in table 'PlayerHousesSet'
ALTER TABLE [dbo].[PlayerHousesSet]
ADD CONSTRAINT [FK_PlayerHousesPlayer]
    FOREIGN KEY ([Player_Id])
    REFERENCES [dbo].[Players]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PlayerHousesPlayer'
CREATE INDEX [IX_FK_PlayerHousesPlayer]
ON [dbo].[PlayerHousesSet]
    ([Player_Id]);
GO

-- Creating foreign key on [Area_Id] in table 'PlayerHousesSet'
ALTER TABLE [dbo].[PlayerHousesSet]
ADD CONSTRAINT [FK_PlayerHousesArea]
    FOREIGN KEY ([Area_Id])
    REFERENCES [dbo].[Areas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PlayerHousesArea'
CREATE INDEX [IX_FK_PlayerHousesArea]
ON [dbo].[PlayerHousesSet]
    ([Area_Id]);
GO

-- Creating foreign key on [Session_Id] in table 'PlayerHousesSet'
ALTER TABLE [dbo].[PlayerHousesSet]
ADD CONSTRAINT [FK_PlayerHousesSession]
    FOREIGN KEY ([Session_Id])
    REFERENCES [dbo].[Sessions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PlayerHousesSession'
CREATE INDEX [IX_FK_PlayerHousesSession]
ON [dbo].[PlayerHousesSet]
    ([Session_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------