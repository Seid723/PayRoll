USE [C:\USERS\ASUS\DOCUMENTS\PAYROLLDB.MDF]
GO

/****** Object: Table [dbo].[SalaryTb1] Script Date: 11/16/2025 9:12:46 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SalaryTb1] (
    [SalNum]     INT          IDENTITY (1, 1) NOT NULL,
    [EmpId]      INT          NOT NULL,
    [EmpName]    VARCHAR (50) NOT NULL,
    [EmpBasSal]  INT          NOT NULL,
    [EmpBonus]   INT          NOT NULL,
    [EmpAdvance] INT          NOT NULL,
    [EmpTax]     INT          NOT NULL,
    [EmpBalance] INT          NOT NULL,
    [SalPeriod]  VARCHAR (50) NOT NULL
);


