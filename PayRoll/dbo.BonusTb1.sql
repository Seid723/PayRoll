USE [C:\USERS\ASUS\DOCUMENTS\PAYROLLDB.MDF]
GO

/****** Object: Table [dbo].[BonusTb1] Script Date: 11/22/2025 7:04:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BonusTb1] (
    [BId]   INT            IDENTITY (500, 1) NOT NULL,
    [Bname] VARBINARY (50) NOT NULL,
    [Bamt]  INT            NOT NULL
);


