
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/18/2020 11:59:34
-- Generated from EDMX file: D:\entityframework\ModelFirstApproach\Modelfirstschooltask\Modelfirstschooltask\Model1.edmx
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

IF OBJECT_ID(N'[dbo].[FK_SchoolStudent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Students] DROP CONSTRAINT [FK_SchoolStudent];
GO
IF OBJECT_ID(N'[dbo].[FK_ExamStudent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Students] DROP CONSTRAINT [FK_ExamStudent];
GO
IF OBJECT_ID(N'[dbo].[FK_ExamCourse]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Courses] DROP CONSTRAINT [FK_ExamCourse];
GO
IF OBJECT_ID(N'[dbo].[FK_CourseSubject]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Subjects] DROP CONSTRAINT [FK_CourseSubject];
GO
IF OBJECT_ID(N'[dbo].[FK_StudentResult]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Students] DROP CONSTRAINT [FK_StudentResult];
GO
IF OBJECT_ID(N'[dbo].[FK_SubjectResult_Subject]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SubjectResult] DROP CONSTRAINT [FK_SubjectResult_Subject];
GO
IF OBJECT_ID(N'[dbo].[FK_SubjectResult_Result]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SubjectResult] DROP CONSTRAINT [FK_SubjectResult_Result];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Schools]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Schools];
GO
IF OBJECT_ID(N'[dbo].[Students]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Students];
GO
IF OBJECT_ID(N'[dbo].[Courses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Courses];
GO
IF OBJECT_ID(N'[dbo].[Subjects]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Subjects];
GO
IF OBJECT_ID(N'[dbo].[Exams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Exams];
GO
IF OBJECT_ID(N'[dbo].[Results]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Results];
GO
IF OBJECT_ID(N'[dbo].[SubjectResult]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SubjectResult];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Schools'
CREATE TABLE [dbo].[Schools] (
    [Sid] int IDENTITY(1,1) NOT NULL,
    [Sname] nvarchar(max)  NOT NULL,
    [Slocation] nvarchar(max)  NOT NULL,
    [Stid] int  NOT NULL
);
GO

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [Stid] int IDENTITY(1,1) NOT NULL,
    [Stname] nvarchar(max)  NOT NULL,
    [Stgender] nvarchar(max)  NOT NULL,
    [Eid] int  NOT NULL,
    [SchoolSid] int  NOT NULL,
    [Exam_Eid] int  NOT NULL,
    [Result_Rid] int  NOT NULL
);
GO

-- Creating table 'Courses'
CREATE TABLE [dbo].[Courses] (
    [Cid] int IDENTITY(1,1) NOT NULL,
    [Cname] nvarchar(max)  NOT NULL,
    [Ccredits] int  NOT NULL,
    [Subid] int  NOT NULL,
    [ExamEid] int  NOT NULL
);
GO

-- Creating table 'Subjects'
CREATE TABLE [dbo].[Subjects] (
    [Subid] int IDENTITY(1,1) NOT NULL,
    [Subname] nvarchar(max)  NOT NULL,
    [Rid] int  NOT NULL,
    [CourseCid] int  NOT NULL
);
GO

-- Creating table 'Exams'
CREATE TABLE [dbo].[Exams] (
    [Eid] int IDENTITY(1,1) NOT NULL,
    [Ename] nvarchar(max)  NOT NULL,
    [Examlocation] nvarchar(max)  NOT NULL,
    [Cid] int  NOT NULL
);
GO

-- Creating table 'Results'
CREATE TABLE [dbo].[Results] (
    [Rid] int IDENTITY(1,1) NOT NULL,
    [Resdesc] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SubjectResult'
CREATE TABLE [dbo].[SubjectResult] (
    [Subjects_Subid] int  NOT NULL,
    [Results_Rid] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Sid] in table 'Schools'
ALTER TABLE [dbo].[Schools]
ADD CONSTRAINT [PK_Schools]
    PRIMARY KEY CLUSTERED ([Sid] ASC);
GO

-- Creating primary key on [Stid] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([Stid] ASC);
GO

-- Creating primary key on [Cid] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [PK_Courses]
    PRIMARY KEY CLUSTERED ([Cid] ASC);
GO

-- Creating primary key on [Subid] in table 'Subjects'
ALTER TABLE [dbo].[Subjects]
ADD CONSTRAINT [PK_Subjects]
    PRIMARY KEY CLUSTERED ([Subid] ASC);
GO

-- Creating primary key on [Eid] in table 'Exams'
ALTER TABLE [dbo].[Exams]
ADD CONSTRAINT [PK_Exams]
    PRIMARY KEY CLUSTERED ([Eid] ASC);
GO

-- Creating primary key on [Rid] in table 'Results'
ALTER TABLE [dbo].[Results]
ADD CONSTRAINT [PK_Results]
    PRIMARY KEY CLUSTERED ([Rid] ASC);
GO

-- Creating primary key on [Subjects_Subid], [Results_Rid] in table 'SubjectResult'
ALTER TABLE [dbo].[SubjectResult]
ADD CONSTRAINT [PK_SubjectResult]
    PRIMARY KEY CLUSTERED ([Subjects_Subid], [Results_Rid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [SchoolSid] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_SchoolStudent]
    FOREIGN KEY ([SchoolSid])
    REFERENCES [dbo].[Schools]
        ([Sid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SchoolStudent'
CREATE INDEX [IX_FK_SchoolStudent]
ON [dbo].[Students]
    ([SchoolSid]);
GO

-- Creating foreign key on [Exam_Eid] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_ExamStudent]
    FOREIGN KEY ([Exam_Eid])
    REFERENCES [dbo].[Exams]
        ([Eid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExamStudent'
CREATE INDEX [IX_FK_ExamStudent]
ON [dbo].[Students]
    ([Exam_Eid]);
GO

-- Creating foreign key on [ExamEid] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [FK_ExamCourse]
    FOREIGN KEY ([ExamEid])
    REFERENCES [dbo].[Exams]
        ([Eid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExamCourse'
CREATE INDEX [IX_FK_ExamCourse]
ON [dbo].[Courses]
    ([ExamEid]);
GO

-- Creating foreign key on [CourseCid] in table 'Subjects'
ALTER TABLE [dbo].[Subjects]
ADD CONSTRAINT [FK_CourseSubject]
    FOREIGN KEY ([CourseCid])
    REFERENCES [dbo].[Courses]
        ([Cid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseSubject'
CREATE INDEX [IX_FK_CourseSubject]
ON [dbo].[Subjects]
    ([CourseCid]);
GO

-- Creating foreign key on [Result_Rid] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_StudentResult]
    FOREIGN KEY ([Result_Rid])
    REFERENCES [dbo].[Results]
        ([Rid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentResult'
CREATE INDEX [IX_FK_StudentResult]
ON [dbo].[Students]
    ([Result_Rid]);
GO

-- Creating foreign key on [Subjects_Subid] in table 'SubjectResult'
ALTER TABLE [dbo].[SubjectResult]
ADD CONSTRAINT [FK_SubjectResult_Subject]
    FOREIGN KEY ([Subjects_Subid])
    REFERENCES [dbo].[Subjects]
        ([Subid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Results_Rid] in table 'SubjectResult'
ALTER TABLE [dbo].[SubjectResult]
ADD CONSTRAINT [FK_SubjectResult_Result]
    FOREIGN KEY ([Results_Rid])
    REFERENCES [dbo].[Results]
        ([Rid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SubjectResult_Result'
CREATE INDEX [IX_FK_SubjectResult_Result]
ON [dbo].[SubjectResult]
    ([Results_Rid]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------