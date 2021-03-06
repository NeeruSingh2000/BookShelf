USE [master]
GO

/****** Object:  Database [BookShelf]    Script Date: 19-02-2018 21:38:57 ******/
CREATE DATABASE [BookShelf]
 GO

USE [BookShelf]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 19-02-2018 21:30:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[Title] [varchar](200) NOT NULL,
	[Author] [varchar](200) NOT NULL,
	[ISBN] [varchar](50) NOT NULL,
	[LoanedTo] [int] NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Insert queries  Script Date: 19-02-2018 21:30:50 ******/

INSERT INTO [dbo].[Book]
           ([Title]
           ,[Author]
           ,[ISBN]
           ,[LoanedTo])
     VALUES
        ('Title1','Author1','ISBN123',null) ; 

INSERT INTO [dbo].[Book]
           ([Title]
           ,[Author]
           ,[ISBN]
           ,[LoanedTo])
     VALUES
        ('Title2','Author2','ISBN456',1) ; 