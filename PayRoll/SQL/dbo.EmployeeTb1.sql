USE [C:\USERS\ASUS\DOCUMENTS\PAYROLLDB.MDF]
GO

/****** Object: Table [dbo].[EmployeeTb1] Script Date: 11/16/2025 9:08:14 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EmployeeTb1] (
    [EmpId]     INT           IDENTITY (1000, 1) NOT NULL,
    [EmpName]   VARCHAR (50)  NOT NULL,
    [EmpGen]    VARCHAR (10)  NOT NULL,
    [EmpDOB]    DATE          NOT NULL,
    [EmpPhone]  VARCHAR (50)  NOT NULL,
    [EmpAdd]    VARCHAR (100) NOT NULL,
    [EmpPos]    VARCHAR (50)  NOT NULL,
    [JoinDate]  DATE          NOT NULL,
    [EmpQual]   VARCHAR (50)  NOT NULL,
    [EmpBasSal] INT           NOT NULL
);


