USE [C:\USERS\ASUS\DOCUMENTS\PAYROLLDB.MDF]
GO

/****** Object: Table [dbo].[AttendanceTb1] Script Date: 11/22/2025 7:04:41 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AttendanceTb1] (
    [AttNum]     INT          IDENTITY (1, 1) NOT NULL,
    [EmpId]      INT          NOT NULL,
    [EmpName]    VARCHAR (50) NOT NULL,
    [DayPres]    INT          NOT NULL,
    [DayAbs]     INT          NOT NULL,
    [DayExcused] INT          NOT NULL,
    [Period]     VARCHAR (50) NOT NULL
);


