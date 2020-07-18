create database example
go
USE [example]
GO

CREATE TABLE [dbo].[tblTask](
	[Id] [int] IDENTITY(1,1) primary key,
	[Name] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[City] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
)
GO


