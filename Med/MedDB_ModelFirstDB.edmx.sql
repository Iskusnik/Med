
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/06/2018 18:13:55
-- Generated from EDMX file: C:\Users\IskusnikXD\Source\Repos\Med\Med\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MedDB1];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PatientHaveIllness]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[IllnessSet] DROP CONSTRAINT [FK_PatientHaveIllness];
GO
IF OBJECT_ID(N'[dbo].[FK_PatientHaveMedCard]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MedCardSet] DROP CONSTRAINT [FK_PatientHaveMedCard];
GO
IF OBJECT_ID(N'[dbo].[FK_MedCardHaveDoctorRecord]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DoctorRecordSet] DROP CONSTRAINT [FK_MedCardHaveDoctorRecord];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonHaveDocuments]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonSet] DROP CONSTRAINT [FK_PersonHaveDocuments];
GO
IF OBJECT_ID(N'[dbo].[FK_OperatorMakesVisitInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VisitInfoSet] DROP CONSTRAINT [FK_OperatorMakesVisitInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_DoctorMakesDoctorRecord]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DoctorRecordSet] DROP CONSTRAINT [FK_DoctorMakesDoctorRecord];
GO
IF OBJECT_ID(N'[dbo].[FK_DoctorFreeTime]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FreeTimeSet] DROP CONSTRAINT [FK_DoctorFreeTime];
GO
IF OBJECT_ID(N'[dbo].[FK_DoctorWorkTime]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WorkTimeSet] DROP CONSTRAINT [FK_DoctorWorkTime];
GO
IF OBJECT_ID(N'[dbo].[FK_WorkTimeVisitInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WorkTimeSet] DROP CONSTRAINT [FK_WorkTimeVisitInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_Patient_inherits_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonSet_Patient] DROP CONSTRAINT [FK_Patient_inherits_Person];
GO
IF OBJECT_ID(N'[dbo].[FK_Operator_inherits_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonSet_Operator] DROP CONSTRAINT [FK_Operator_inherits_Person];
GO
IF OBJECT_ID(N'[dbo].[FK_Doctor_inherits_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonSet_Doctor] DROP CONSTRAINT [FK_Doctor_inherits_Person];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[IllnessSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[IllnessSet];
GO
IF OBJECT_ID(N'[dbo].[MedCardSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MedCardSet];
GO
IF OBJECT_ID(N'[dbo].[DocumentsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DocumentsSet];
GO
IF OBJECT_ID(N'[dbo].[PersonSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonSet];
GO
IF OBJECT_ID(N'[dbo].[DoctorRecordSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DoctorRecordSet];
GO
IF OBJECT_ID(N'[dbo].[VisitInfoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VisitInfoSet];
GO
IF OBJECT_ID(N'[dbo].[FreeTimeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FreeTimeSet];
GO
IF OBJECT_ID(N'[dbo].[WorkTimeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WorkTimeSet];
GO
IF OBJECT_ID(N'[dbo].[PersonSet_Patient]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonSet_Patient];
GO
IF OBJECT_ID(N'[dbo].[PersonSet_Operator]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonSet_Operator];
GO
IF OBJECT_ID(N'[dbo].[PersonSet_Doctor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonSet_Doctor];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'IllnessSet'
CREATE TABLE [dbo].[IllnessSet] (
    [Name] nvarchar(max)  NOT NULL,
    [Patient_FullName] nvarchar(max)  NOT NULL,
    [Patient_BirthDate] datetime  NOT NULL
);
GO

-- Creating table 'MedCardSet'
CREATE TABLE [dbo].[MedCardSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Patient_FullName] nvarchar(max)  NOT NULL,
    [Patient_BirthDate] datetime  NOT NULL
);
GO

-- Creating table 'DocumentsSet'
CREATE TABLE [dbo].[DocumentsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
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
    [Documents_Id] int  NOT NULL,
    [Documents_DocumentName] nvarchar(max)  NOT NULL
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
    [Date] nvarchar(max)  NOT NULL,
    [MedCard_Id] int  NOT NULL,
    [Doctor_FullName] nvarchar(max)  NOT NULL,
    [Doctor_BirthDate] datetime  NOT NULL
);
GO

-- Creating table 'VisitInfoSet'
CREATE TABLE [dbo].[VisitInfoSet] (
    [Doctor] int IDENTITY(1,1) NOT NULL,
    [OperatorFullName] nvarchar(max)  NOT NULL,
    [OperatorBirthDate] datetime  NOT NULL,
    [DateStart] datetime  NOT NULL,
    [DateFinish] datetime  NOT NULL
);
GO

-- Creating table 'FreeTimeSet'
CREATE TABLE [dbo].[FreeTimeSet] (
    [Start] datetime  NOT NULL,
    [Finish] datetime  NOT NULL,
    [Doctor_FullName] nvarchar(max)  NOT NULL,
    [Doctor_BirthDate] datetime  NOT NULL
);
GO

-- Creating table 'WorkTimeSet'
CREATE TABLE [dbo].[WorkTimeSet] (
    [Start] datetime  NOT NULL,
    [Finish] datetime  NOT NULL,
    [Doctor_FullName] nvarchar(max)  NOT NULL,
    [Doctor_BirthDate] datetime  NOT NULL,
    [VisitInfo_Doctor] int  NOT NULL,
    [VisitInfo_DateStart] datetime  NOT NULL,
    [VisitInfo_DateFinish] datetime  NOT NULL
);
GO

-- Creating table 'PersonSet_Patient'
CREATE TABLE [dbo].[PersonSet_Patient] (
    [InsurancePolicyNum] nvarchar(max)  NOT NULL,
    [WorkIncapacityListNum] nvarchar(max)  NOT NULL,
    [BloodType] tinyint  NOT NULL,
    [Rhesus] nvarchar(max)  NOT NULL,
    [FullName] nvarchar(max)  NOT NULL,
    [BirthDate] datetime  NOT NULL
);
GO

-- Creating table 'PersonSet_Operator'
CREATE TABLE [dbo].[PersonSet_Operator] (
    [Login] int IDENTITY(1,1) NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [FullName] nvarchar(max)  NOT NULL,
    [BirthDate] datetime  NOT NULL
);
GO

-- Creating table 'PersonSet_Doctor'
CREATE TABLE [dbo].[PersonSet_Doctor] (
    [Education] int IDENTITY(1,1) NOT NULL,
    [Job] nvarchar(max)  NOT NULL,
    [Memberships] nvarchar(max)  NOT NULL,
    [FullName] nvarchar(max)  NOT NULL,
    [BirthDate] datetime  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Name] in table 'IllnessSet'
ALTER TABLE [dbo].[IllnessSet]
ADD CONSTRAINT [PK_IllnessSet]
    PRIMARY KEY CLUSTERED ([Name] ASC);
GO

-- Creating primary key on [Id] in table 'MedCardSet'
ALTER TABLE [dbo].[MedCardSet]
ADD CONSTRAINT [PK_MedCardSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id], [DocumentName] in table 'DocumentsSet'
ALTER TABLE [dbo].[DocumentsSet]
ADD CONSTRAINT [PK_DocumentsSet]
    PRIMARY KEY CLUSTERED ([Id], [DocumentName] ASC);
GO

-- Creating primary key on [FullName], [BirthDate] in table 'PersonSet'
ALTER TABLE [dbo].[PersonSet]
ADD CONSTRAINT [PK_PersonSet]
    PRIMARY KEY CLUSTERED ([FullName], [BirthDate] ASC);
GO

-- Creating primary key on [DoctorInfo], [Date] in table 'DoctorRecordSet'
ALTER TABLE [dbo].[DoctorRecordSet]
ADD CONSTRAINT [PK_DoctorRecordSet]
    PRIMARY KEY CLUSTERED ([DoctorInfo], [Date] ASC);
GO

-- Creating primary key on [Doctor], [DateStart], [DateFinish] in table 'VisitInfoSet'
ALTER TABLE [dbo].[VisitInfoSet]
ADD CONSTRAINT [PK_VisitInfoSet]
    PRIMARY KEY CLUSTERED ([Doctor], [DateStart], [DateFinish] ASC);
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

-- Creating primary key on [FullName], [BirthDate] in table 'PersonSet_Patient'
ALTER TABLE [dbo].[PersonSet_Patient]
ADD CONSTRAINT [PK_PersonSet_Patient]
    PRIMARY KEY CLUSTERED ([FullName], [BirthDate] ASC);
GO

-- Creating primary key on [FullName], [BirthDate] in table 'PersonSet_Operator'
ALTER TABLE [dbo].[PersonSet_Operator]
ADD CONSTRAINT [PK_PersonSet_Operator]
    PRIMARY KEY CLUSTERED ([FullName], [BirthDate] ASC);
GO

-- Creating primary key on [FullName], [BirthDate] in table 'PersonSet_Doctor'
ALTER TABLE [dbo].[PersonSet_Doctor]
ADD CONSTRAINT [PK_PersonSet_Doctor]
    PRIMARY KEY CLUSTERED ([FullName], [BirthDate] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Patient_FullName], [Patient_BirthDate] in table 'IllnessSet'
ALTER TABLE [dbo].[IllnessSet]
ADD CONSTRAINT [FK_PatientHaveIllness]
    FOREIGN KEY ([Patient_FullName], [Patient_BirthDate])
    REFERENCES [dbo].[PersonSet_Patient]
        ([FullName], [BirthDate])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientHaveIllness'
CREATE INDEX [IX_FK_PatientHaveIllness]
ON [dbo].[IllnessSet]
    ([Patient_FullName], [Patient_BirthDate]);
GO

-- Creating foreign key on [Patient_FullName], [Patient_BirthDate] in table 'MedCardSet'
ALTER TABLE [dbo].[MedCardSet]
ADD CONSTRAINT [FK_PatientHaveMedCard]
    FOREIGN KEY ([Patient_FullName], [Patient_BirthDate])
    REFERENCES [dbo].[PersonSet_Patient]
        ([FullName], [BirthDate])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PatientHaveMedCard'
CREATE INDEX [IX_FK_PatientHaveMedCard]
ON [dbo].[MedCardSet]
    ([Patient_FullName], [Patient_BirthDate]);
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

-- Creating foreign key on [Documents_Id], [Documents_DocumentName] in table 'PersonSet'
ALTER TABLE [dbo].[PersonSet]
ADD CONSTRAINT [FK_PersonHaveDocuments]
    FOREIGN KEY ([Documents_Id], [Documents_DocumentName])
    REFERENCES [dbo].[DocumentsSet]
        ([Id], [DocumentName])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonHaveDocuments'
CREATE INDEX [IX_FK_PersonHaveDocuments]
ON [dbo].[PersonSet]
    ([Documents_Id], [Documents_DocumentName]);
GO

-- Creating foreign key on [OperatorFullName], [OperatorBirthDate] in table 'VisitInfoSet'
ALTER TABLE [dbo].[VisitInfoSet]
ADD CONSTRAINT [FK_OperatorMakesVisitInfo]
    FOREIGN KEY ([OperatorFullName], [OperatorBirthDate])
    REFERENCES [dbo].[PersonSet_Operator]
        ([FullName], [BirthDate])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OperatorMakesVisitInfo'
CREATE INDEX [IX_FK_OperatorMakesVisitInfo]
ON [dbo].[VisitInfoSet]
    ([OperatorFullName], [OperatorBirthDate]);
GO

-- Creating foreign key on [Doctor_FullName], [Doctor_BirthDate] in table 'DoctorRecordSet'
ALTER TABLE [dbo].[DoctorRecordSet]
ADD CONSTRAINT [FK_DoctorMakesDoctorRecord]
    FOREIGN KEY ([Doctor_FullName], [Doctor_BirthDate])
    REFERENCES [dbo].[PersonSet_Doctor]
        ([FullName], [BirthDate])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DoctorMakesDoctorRecord'
CREATE INDEX [IX_FK_DoctorMakesDoctorRecord]
ON [dbo].[DoctorRecordSet]
    ([Doctor_FullName], [Doctor_BirthDate]);
GO

-- Creating foreign key on [Doctor_FullName], [Doctor_BirthDate] in table 'FreeTimeSet'
ALTER TABLE [dbo].[FreeTimeSet]
ADD CONSTRAINT [FK_DoctorFreeTime]
    FOREIGN KEY ([Doctor_FullName], [Doctor_BirthDate])
    REFERENCES [dbo].[PersonSet_Doctor]
        ([FullName], [BirthDate])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DoctorFreeTime'
CREATE INDEX [IX_FK_DoctorFreeTime]
ON [dbo].[FreeTimeSet]
    ([Doctor_FullName], [Doctor_BirthDate]);
GO

-- Creating foreign key on [Doctor_FullName], [Doctor_BirthDate] in table 'WorkTimeSet'
ALTER TABLE [dbo].[WorkTimeSet]
ADD CONSTRAINT [FK_DoctorWorkTime]
    FOREIGN KEY ([Doctor_FullName], [Doctor_BirthDate])
    REFERENCES [dbo].[PersonSet_Doctor]
        ([FullName], [BirthDate])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DoctorWorkTime'
CREATE INDEX [IX_FK_DoctorWorkTime]
ON [dbo].[WorkTimeSet]
    ([Doctor_FullName], [Doctor_BirthDate]);
GO

-- Creating foreign key on [VisitInfo_Doctor], [VisitInfo_DateStart], [VisitInfo_DateFinish] in table 'WorkTimeSet'
ALTER TABLE [dbo].[WorkTimeSet]
ADD CONSTRAINT [FK_WorkTimeVisitInfo]
    FOREIGN KEY ([VisitInfo_Doctor], [VisitInfo_DateStart], [VisitInfo_DateFinish])
    REFERENCES [dbo].[VisitInfoSet]
        ([Doctor], [DateStart], [DateFinish])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WorkTimeVisitInfo'
CREATE INDEX [IX_FK_WorkTimeVisitInfo]
ON [dbo].[WorkTimeSet]
    ([VisitInfo_Doctor], [VisitInfo_DateStart], [VisitInfo_DateFinish]);
GO

-- Creating foreign key on [FullName], [BirthDate] in table 'PersonSet_Patient'
ALTER TABLE [dbo].[PersonSet_Patient]
ADD CONSTRAINT [FK_Patient_inherits_Person]
    FOREIGN KEY ([FullName], [BirthDate])
    REFERENCES [dbo].[PersonSet]
        ([FullName], [BirthDate])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [FullName], [BirthDate] in table 'PersonSet_Operator'
ALTER TABLE [dbo].[PersonSet_Operator]
ADD CONSTRAINT [FK_Operator_inherits_Person]
    FOREIGN KEY ([FullName], [BirthDate])
    REFERENCES [dbo].[PersonSet]
        ([FullName], [BirthDate])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [FullName], [BirthDate] in table 'PersonSet_Doctor'
ALTER TABLE [dbo].[PersonSet_Doctor]
ADD CONSTRAINT [FK_Doctor_inherits_Person]
    FOREIGN KEY ([FullName], [BirthDate])
    REFERENCES [dbo].[PersonSet]
        ([FullName], [BirthDate])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------