
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/11/2018 18:36:25
-- Generated from EDMX file: C:\Users\IskusnikXD\Source\Repos\Med\Med2\ModelMedDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [NewMedDB];
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

-- Creating table 'IllnessSet'
CREATE TABLE [dbo].[IllnessSet] (
    [Name] nvarchar(max)  NOT NULL,
    [Hash] bigint  NOT NULL,
    [Patient_BirthDate] datetime  NOT NULL,
    [Patient_NameHashID] bigint  NOT NULL
);
GO

-- Creating table 'MedCardSet'
CREATE TABLE [dbo].[MedCardSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Patient_BirthDate] datetime  NOT NULL,
    [Patient_NameHashID] bigint  NOT NULL
);
GO

-- Creating table 'DocumentsSet'
CREATE TABLE [dbo].[DocumentsSet] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [DocumentName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PersonSet'
CREATE TABLE [dbo].[PersonSet] (
    [FullName] nvarchar(max)  NOT NULL,
    [Gender] nvarchar(max)  NOT NULL,
    [BirthDate] datetime  NOT NULL,
    [Nationality] nvarchar(max)  NOT NULL,
    [LiveAdress] nvarchar(max)  NOT NULL,
    [RegAdress] nvarchar(max)  NOT NULL,
    [RegDate] datetime  NOT NULL,
    [InsuranceBillNum] nvarchar(max)  NOT NULL,
    [NameHashID] bigint  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Documents_Id] bigint  NOT NULL
);
GO

-- Creating table 'DoctorRecordSet'
CREATE TABLE [dbo].[DoctorRecordSet] (
    [Anamnesis] nvarchar(max)  NOT NULL,
    [Diagnosis] nvarchar(max)  NOT NULL,
    [HelpType] nvarchar(max)  NOT NULL,
    [HelpAmount] nvarchar(max)  NOT NULL,
    [Result] nvarchar(max)  NOT NULL,
    [Standarts] nvarchar(max)  NOT NULL,
    [DoctorInfo] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [DoctorID] bigint  NOT NULL,
    [MedCard_Id] int  NOT NULL,
    [Doctor_BirthDate] datetime  NOT NULL,
    [Doctor_NameHashID] bigint  NOT NULL
);
GO

-- Creating table 'VisitInfoSet'
CREATE TABLE [dbo].[VisitInfoSet] (
    [PatientFullName] nvarchar(max)  NOT NULL,
    [PatientBirthDate] datetime  NOT NULL,
    [DateStart] datetime  NOT NULL,
    [DateFinish] datetime  NOT NULL,
    [DoctorID] bigint  NOT NULL,
    [WorkTime_Start] datetime  NOT NULL,
    [WorkTime_Finish] datetime  NOT NULL,
    [Patient_BirthDate] datetime  NOT NULL,
    [Patient_NameHashID] bigint  NOT NULL
);
GO

-- Creating table 'FreeTimeSet'
CREATE TABLE [dbo].[FreeTimeSet] (
    [Start] datetime  NOT NULL,
    [Finish] datetime  NOT NULL,
    [Doctor_BirthDate] datetime  NOT NULL,
    [Doctor_NameHashID] bigint  NOT NULL
);
GO

-- Creating table 'WorkTimeSet'
CREATE TABLE [dbo].[WorkTimeSet] (
    [Start] datetime  NOT NULL,
    [Finish] datetime  NOT NULL,
    [Doctor_BirthDate] datetime  NOT NULL,
    [Doctor_NameHashID] bigint  NOT NULL
);
GO

-- Creating table 'PersonSet_Patient'
CREATE TABLE [dbo].[PersonSet_Patient] (
    [InsurancePolicyNum] nvarchar(max)  NOT NULL,
    [WorkIncapacityListNum] nvarchar(max)  NOT NULL,
    [BloodType] tinyint  NOT NULL,
    [Rhesus] nvarchar(max)  NOT NULL,
    [BirthDate] datetime  NOT NULL,
    [NameHashID] bigint  NOT NULL
);
GO

-- Creating table 'PersonSet_Doctor'
CREATE TABLE [dbo].[PersonSet_Doctor] (
    [Education] int IDENTITY(1,1) NOT NULL,
    [Job] nvarchar(max)  NOT NULL,
    [Memberships] nvarchar(max)  NOT NULL,
    [BirthDate] datetime  NOT NULL,
    [NameHashID] bigint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Hash] in table 'IllnessSet'
ALTER TABLE [dbo].[IllnessSet]
ADD CONSTRAINT [PK_IllnessSet]
    PRIMARY KEY CLUSTERED ([Hash] ASC);
GO

-- Creating primary key on [Id] in table 'MedCardSet'
ALTER TABLE [dbo].[MedCardSet]
ADD CONSTRAINT [PK_MedCardSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DocumentsSet'
ALTER TABLE [dbo].[DocumentsSet]
ADD CONSTRAINT [PK_DocumentsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [BirthDate], [NameHashID] in table 'PersonSet'
ALTER TABLE [dbo].[PersonSet]
ADD CONSTRAINT [PK_PersonSet]
    PRIMARY KEY CLUSTERED ([BirthDate], [NameHashID] ASC);
GO

-- Creating primary key on [Date], [DoctorID] in table 'DoctorRecordSet'
ALTER TABLE [dbo].[DoctorRecordSet]
ADD CONSTRAINT [PK_DoctorRecordSet]
    PRIMARY KEY CLUSTERED ([Date], [DoctorID] ASC);
GO

-- Creating primary key on [DateStart], [DateFinish], [DoctorID] in table 'VisitInfoSet'
ALTER TABLE [dbo].[VisitInfoSet]
ADD CONSTRAINT [PK_VisitInfoSet]
    PRIMARY KEY CLUSTERED ([DateStart], [DateFinish], [DoctorID] ASC);
GO

-- Creating primary key on [Start], [Finish] in table 'FreeTimeSet'
ALTER TABLE [dbo].[FreeTimeSet]
ADD CONSTRAINT [PK_FreeTimeSet]
    PRIMARY KEY CLUSTERED ([Start], [Finish] ASC);
GO

-- Creating primary key on [Start], [Finish] in table 'WorkTimeSet'
ALTER TABLE [dbo].[WorkTimeSet]
ADD CONSTRAINT [PK_WorkTimeSet]
    PRIMARY KEY CLUSTERED ([Start], [Finish] ASC);
GO

-- Creating primary key on [BirthDate], [NameHashID] in table 'PersonSet_Patient'
ALTER TABLE [dbo].[PersonSet_Patient]
ADD CONSTRAINT [PK_PersonSet_Patient]
    PRIMARY KEY CLUSTERED ([BirthDate], [NameHashID] ASC);
GO

-- Creating primary key on [BirthDate], [NameHashID] in table 'PersonSet_Doctor'
ALTER TABLE [dbo].[PersonSet_Doctor]
ADD CONSTRAINT [PK_PersonSet_Doctor]
    PRIMARY KEY CLUSTERED ([BirthDate], [NameHashID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Patient_BirthDate], [Patient_NameHashID] in table 'IllnessSet'
ALTER TABLE [dbo].[IllnessSet]
ADD CONSTRAINT [FK_PatientHaveIllness]
    FOREIGN KEY ([Patient_BirthDate], [Patient_NameHashID])
    REFERENCES [dbo].[PersonSet_Patient]
        ([BirthDate], [NameHashID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientHaveIllness'
CREATE INDEX [IX_FK_PatientHaveIllness]
ON [dbo].[IllnessSet]
    ([Patient_BirthDate], [Patient_NameHashID]);
GO

-- Creating foreign key on [Patient_BirthDate], [Patient_NameHashID] in table 'MedCardSet'
ALTER TABLE [dbo].[MedCardSet]
ADD CONSTRAINT [FK_PatientHaveMedCard]
    FOREIGN KEY ([Patient_BirthDate], [Patient_NameHashID])
    REFERENCES [dbo].[PersonSet_Patient]
        ([BirthDate], [NameHashID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientHaveMedCard'
CREATE INDEX [IX_FK_PatientHaveMedCard]
ON [dbo].[MedCardSet]
    ([Patient_BirthDate], [Patient_NameHashID]);
GO

-- Creating foreign key on [MedCard_Id] in table 'DoctorRecordSet'
ALTER TABLE [dbo].[DoctorRecordSet]
ADD CONSTRAINT [FK_MedCardHaveDoctorRecord]
    FOREIGN KEY ([MedCard_Id])
    REFERENCES [dbo].[MedCardSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MedCardHaveDoctorRecord'
CREATE INDEX [IX_FK_MedCardHaveDoctorRecord]
ON [dbo].[DoctorRecordSet]
    ([MedCard_Id]);
GO

-- Creating foreign key on [Documents_Id] in table 'PersonSet'
ALTER TABLE [dbo].[PersonSet]
ADD CONSTRAINT [FK_PersonHaveDocuments]
    FOREIGN KEY ([Documents_Id])
    REFERENCES [dbo].[DocumentsSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonHaveDocuments'
CREATE INDEX [IX_FK_PersonHaveDocuments]
ON [dbo].[PersonSet]
    ([Documents_Id]);
GO

-- Creating foreign key on [Doctor_BirthDate], [Doctor_NameHashID] in table 'DoctorRecordSet'
ALTER TABLE [dbo].[DoctorRecordSet]
ADD CONSTRAINT [FK_DoctorMakesDoctorRecord]
    FOREIGN KEY ([Doctor_BirthDate], [Doctor_NameHashID])
    REFERENCES [dbo].[PersonSet_Doctor]
        ([BirthDate], [NameHashID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DoctorMakesDoctorRecord'
CREATE INDEX [IX_FK_DoctorMakesDoctorRecord]
ON [dbo].[DoctorRecordSet]
    ([Doctor_BirthDate], [Doctor_NameHashID]);
GO

-- Creating foreign key on [Doctor_BirthDate], [Doctor_NameHashID] in table 'FreeTimeSet'
ALTER TABLE [dbo].[FreeTimeSet]
ADD CONSTRAINT [FK_DoctorFreeTime]
    FOREIGN KEY ([Doctor_BirthDate], [Doctor_NameHashID])
    REFERENCES [dbo].[PersonSet_Doctor]
        ([BirthDate], [NameHashID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DoctorFreeTime'
CREATE INDEX [IX_FK_DoctorFreeTime]
ON [dbo].[FreeTimeSet]
    ([Doctor_BirthDate], [Doctor_NameHashID]);
GO

-- Creating foreign key on [Doctor_BirthDate], [Doctor_NameHashID] in table 'WorkTimeSet'
ALTER TABLE [dbo].[WorkTimeSet]
ADD CONSTRAINT [FK_DoctorWorkTime]
    FOREIGN KEY ([Doctor_BirthDate], [Doctor_NameHashID])
    REFERENCES [dbo].[PersonSet_Doctor]
        ([BirthDate], [NameHashID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DoctorWorkTime'
CREATE INDEX [IX_FK_DoctorWorkTime]
ON [dbo].[WorkTimeSet]
    ([Doctor_BirthDate], [Doctor_NameHashID]);
GO

-- Creating foreign key on [WorkTime_Start], [WorkTime_Finish] in table 'VisitInfoSet'
ALTER TABLE [dbo].[VisitInfoSet]
ADD CONSTRAINT [FK_VisitInfoWorkTime]
    FOREIGN KEY ([WorkTime_Start], [WorkTime_Finish])
    REFERENCES [dbo].[WorkTimeSet]
        ([Start], [Finish])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VisitInfoWorkTime'
CREATE INDEX [IX_FK_VisitInfoWorkTime]
ON [dbo].[VisitInfoSet]
    ([WorkTime_Start], [WorkTime_Finish]);
GO

-- Creating foreign key on [Patient_BirthDate], [Patient_NameHashID] in table 'VisitInfoSet'
ALTER TABLE [dbo].[VisitInfoSet]
ADD CONSTRAINT [FK_PatientVisitInfo]
    FOREIGN KEY ([Patient_BirthDate], [Patient_NameHashID])
    REFERENCES [dbo].[PersonSet_Patient]
        ([BirthDate], [NameHashID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientVisitInfo'
CREATE INDEX [IX_FK_PatientVisitInfo]
ON [dbo].[VisitInfoSet]
    ([Patient_BirthDate], [Patient_NameHashID]);
GO

-- Creating foreign key on [BirthDate], [NameHashID] in table 'PersonSet_Patient'
ALTER TABLE [dbo].[PersonSet_Patient]
ADD CONSTRAINT [FK_Patient_inherits_Person]
    FOREIGN KEY ([BirthDate], [NameHashID])
    REFERENCES [dbo].[PersonSet]
        ([BirthDate], [NameHashID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [BirthDate], [NameHashID] in table 'PersonSet_Doctor'
ALTER TABLE [dbo].[PersonSet_Doctor]
ADD CONSTRAINT [FK_Doctor_inherits_Person]
    FOREIGN KEY ([BirthDate], [NameHashID])
    REFERENCES [dbo].[PersonSet]
        ([BirthDate], [NameHashID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------