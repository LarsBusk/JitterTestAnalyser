USE [JitterTestData]
GO

/****** Object:  StoredProcedure [dbo].[AddNewTestSetup]    Script Date: 30-03-2020 16:33:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




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
	,@SystemID int
	,@OpcClient nvarchar(20)
	,@NlcpPoints int
	,@Comment nvarchar(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @NewID int

	INSERT INTO TestSetup (
		NovaVersion, MantaVersion, Product, ImageLength, RawDataEnabled, FODEnabled, SurveilanceEnabled, StatisticsEnabled, MeasureFrom, ConvSpeed, DataBaseSize, CsvFile, SystemID, OpcClient, NlcpPoints, Comment, ExcludeFromSumery) 
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
		,@CsvFile
		,@SystemID
		,@OpcClient
		,@NlcpPoints
		,@Comment
		,0)

	SELECT @NewID = MAX(SetupID) FROM TestSetup
	RETURN @NewID

END
GO


