USE [master]

/****** Object:  Database [JitterTestData]    Script Date: 15-04-2015 09:07:41 ******/
CREATE DATABASE [JitterTestData]
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [JitterTestData].[dbo].[sp_fulltext_database] @action = 'enable'
end
ALTER DATABASE [JitterTestData] SET ANSI_NULL_DEFAULT OFF

ALTER DATABASE [JitterTestData] SET ANSI_NULLS OFF

ALTER DATABASE [JitterTestData] SET ANSI_PADDING OFF

ALTER DATABASE [JitterTestData] SET ANSI_WARNINGS OFF

ALTER DATABASE [JitterTestData] SET ARITHABORT OFF

ALTER DATABASE [JitterTestData] SET AUTO_CLOSE OFF

ALTER DATABASE [JitterTestData] SET AUTO_CREATE_STATISTICS ON

ALTER DATABASE [JitterTestData] SET AUTO_SHRINK OFF

ALTER DATABASE [JitterTestData] SET AUTO_UPDATE_STATISTICS ON

ALTER DATABASE [JitterTestData] SET CURSOR_CLOSE_ON_COMMIT OFF

ALTER DATABASE [JitterTestData] SET CURSOR_DEFAULT  GLOBAL

ALTER DATABASE [JitterTestData] SET CONCAT_NULL_YIELDS_NULL OFF

ALTER DATABASE [JitterTestData] SET NUMERIC_ROUNDABORT OFF

ALTER DATABASE [JitterTestData] SET QUOTED_IDENTIFIER OFF

ALTER DATABASE [JitterTestData] SET RECURSIVE_TRIGGERS OFF

ALTER DATABASE [JitterTestData] SET  DISABLE_BROKER

ALTER DATABASE [JitterTestData] SET AUTO_UPDATE_STATISTICS_ASYNC OFF

ALTER DATABASE [JitterTestData] SET DATE_CORRELATION_OPTIMIZATION OFF

ALTER DATABASE [JitterTestData] SET TRUSTWORTHY OFF

ALTER DATABASE [JitterTestData] SET ALLOW_SNAPSHOT_ISOLATION OFF

ALTER DATABASE [JitterTestData] SET PARAMETERIZATION SIMPLE

ALTER DATABASE [JitterTestData] SET READ_COMMITTED_SNAPSHOT OFF

ALTER DATABASE [JitterTestData] SET RECOVERY FULL

ALTER DATABASE [JitterTestData] SET  MULTI_USER

ALTER DATABASE [JitterTestData] SET PAGE_VERIFY CHECKSUM

ALTER DATABASE [JitterTestData] SET DB_CHAINING OFF

ALTER DATABASE [JitterTestData] SET  READ_WRITE

USE [JitterTestData]

/****** Object:  Table [dbo].[TestSystem]    Script Date: 15-04-2015 09:08:50 ******/
SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;

CREATE TABLE [dbo].[TestSystem](
	[SystemID] [int] IDENTITY (1,1),
	[Name] [nvarchar](50) NOT NULL,
	[HardWare] [nvarchar](50) NOT NULL,
	[RamSize] [int] NOT NULL,
	[DateForImage] [DateTime] NOT NULL
 CONSTRAINT [PK_System] PRIMARY KEY CLUSTERED 
(
	[SystemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];


USE [JitterTestData];

/****** Object:  Table [dbo].[TestSetup]    Script Date: 15-04-2015 09:08:39 ******/
SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;

CREATE TABLE [dbo].[TestSetup](
	[SetupID] [int] IDENTITY (1,1),
	[NovaVersion] [nvarchar](50) NOT NULL,
	[MantaVersion] [nvarchar](50) NOT NULL,
	[Product] [nvarchar](50) NOT NULL,
	[ImageLength] [int] NOT NULL,
	[RawDataEnabled] [bit] NOT NULL,
	[FODEnabled] [bit] NOT NULL,
	[SurveilanceEnabled] [bit] NOT NULL,
	[StatisticsEnabled] [bit] NOT NULL,
	[MeasureFrom] [nvarchar](50) NOT NULL,
	[ConvSpeed] [int] NOT NULL,
	[DataBaseSize] [int] NOT NULL,
	[CsvFile] [nvarchar](max) NULL
 CONSTRAINT [PK_TestSetup] PRIMARY KEY CLUSTERED 
(
	[SetupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];


ALTER TABLE [dbo].[TestSetup]  WITH CHECK ADD  CONSTRAINT [FK_TestSetup_Delays] FOREIGN KEY([SetupID])
REFERENCES [dbo].[TestSetup] ([SetupID]);

ALTER TABLE [dbo].[TestSetup] CHECK CONSTRAINT [FK_TestSetup_Delays];

USE [JitterTestData];

/****** Object:  UserDefinedFunction [dbo].[GetNextTestSetupID]    Script Date: 15-04-2015 09:12:04 ******/
SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;


USE [JitterTestData];

/****** Object:  Table [dbo].[Delays]    Script Date: 15-04-2015 09:08:31 ******/
SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;

CREATE TABLE [dbo].[Delays](
	[DelayID] [int] IDENTITY(1,1),
	[TimeStamp] [datetime] NOT NULL,
	[Delay] [int] NOT NULL,
	[SampleID] [int] NOT NULL,
	[SystemID] [int] NOT NULL,
	[SetupID] [int] NOT NULL,
 CONSTRAINT [PK_Delays] PRIMARY KEY CLUSTERED 
(
	[DelayID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY];

ALTER TABLE [dbo].[Delays]  WITH CHECK ADD  CONSTRAINT [FK_Delays_Setup] FOREIGN KEY([SetupID])
REFERENCES [dbo].[TestSetup] ([SetupID]);

ALTER TABLE [dbo].[Delays] CHECK CONSTRAINT [FK_Delays_Setup];

ALTER TABLE [dbo].[Delays]  WITH CHECK ADD  CONSTRAINT [FK_Delays_System] FOREIGN KEY([SystemID])
REFERENCES [dbo].[TestSystem] ([SystemID]);

ALTER TABLE [dbo].[Delays] CHECK CONSTRAINT [FK_Delays_System]
GO

--========================CREATE FUNCTIONS====================================================


USE [JitterTestData]

/****** Object:  UserDefinedFunction [dbo].[GetNextDelayID]    Script Date: 15-04-2015 09:12:09 ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddNewTestSetup] 
	-- Add the parameters for the stored procedure here
	@NovaVersion nvarchar(50)
	,@MantaVersion nvarchar(50)
	,@Product nvarchar(50)
	,@ImageLength int
	,@RawDataEnabled bit
	,@FODEnabled bit
	,@SurveilanceEnabled bit
	,@StatisticsEnabled bit
	,@MeasureFrom nvarchar(50)
	,@ConvSpeed int
	,@DataBaseSize int
	,@CsvFile nvarchar(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @NewID int

	INSERT INTO TestSetup (
		NovaVersion, MantaVersion, Product, ImageLength, RawDataEnabled, FODEnabled, SurveilanceEnabled, StatisticsEnabled, MeasureFrom, ConvSpeed, DataBaseSize, CsvFile) 
		VALUES (
		@NovaVersion 
		,@MantaVersion 
		,@Product 
		,@ImageLength 
		,@RawDataEnabled 
		,@FODEnabled 
		,@SurveilanceEnabled
		,@StatisticsEnabled
		,@MeasureFrom 
		,@ConvSpeed
		,@DataBaseSize
		,@CsvFile )

	SELECT @NewID = MAX(SetupID) FROM TestSetup
	RETURN @NewID

END
GO

USE [JitterTestData]

/****** Object:  StoredProcedure [dbo].[AddDelayValues]    Script Date: 15-04-2015 09:13:15 ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddDelayValues] 
	-- Add the parameters for the stored procedure here
	@TimeStamp datetime
	,@Delay int
	,@SampleID int
	,@SystemID int
	,@SetupID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	--DECLARE @NewID int = dbo.GetNextTestSetupID()

	INSERT INTO Delays(
		TimeStamp, Delay, SampleID, SystemID, SetupID) 
		VALUES (
		@TimeStamp 
		,@Delay 
		,@SampleID
		,@SystemID 
		,@SetupID )

END
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE DeleteTestSetup 
	@CsvFileName nvarchar(max)
AS
BEGIN
	DECLARE @SetupID int

	SET NOCOUNT ON;
	SELECT @SetupID = MAX(SetupID) FROM TestSetup WHERE CsvFile = @CsvFileName

	DELETE FROM Delays WHERE SetupID = @SetupID
	DELETE FROM TestSetup WHERE SetupID = @SetupID

END
GO

CREATE FUNCTION GetTestSystems()
RETURNS TABLE 
AS
RETURN 
(
	SELECT SystemID, Name
	FROM TestSystem
)
GO
