USE [JitterTestData]
GO

/****** Object:  Table [dbo].[TestSetup]    Script Date: 26-02-2019 09:25:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TestSetup1](
	[SetupID] [int] IDENTITY(1,1) NOT NULL,
	[NovaVersion] [nvarchar](20) NOT NULL,
	[MantaVersion] [nvarchar](20) NOT NULL,
	[IsBoxProduct] [bit] NOT NULL,
	[ImageLength] [int] NOT NULL,
	[RawDataEnabled] [bit] NOT NULL,
	[FODEnabled] [bit] NOT NULL,
	[SurveilanceEnabled] [bit] NOT NULL,
	[StatisticsEnabled] [bit] NOT NULL,
	[MeasureFromManta] [bit] NOT NULL,
	[ConvSpeed] [int] NOT NULL,
	[NlcpPoints] [int] NOT NULL,
	[DataBaseSize] [int] NOT NULL,
	[CsvFile] [nvarchar](max) NULL,
	[SystemID] [int] NOT NULL,
	[ExcludeFromSumery] [bit] NULL,
	[OpcClientIsPDx] [bit] NULL,
 CONSTRAINT [PK_TestSetup1] PRIMARY KEY CLUSTERED 
(
	[SetupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[TestSetup1]  WITH CHECK ADD  CONSTRAINT [FK_TestSetup1_Delays] FOREIGN KEY([SetupID])
REFERENCES [dbo].[TestSetup1] ([SetupID])
GO

ALTER TABLE [dbo].[TestSetup1] CHECK CONSTRAINT [FK_TestSetup1_Delays]
GO


