use JitterTestData;

-- ================================================
-- Template generated from Template Explorer using:
-- Create Inline Function (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION [dbo].[GetJitterResultsSetup] 
(	
	-- Add the parameters for the function here
	@SetupID int
)
RETURNS TABLE 
AS
RETURN 
(
	With DelayValues as
(
	Select		NTilen
			,	Max(Delay) as MaxDelay
			,	Min(Delay) as MinDelay
			,	@SetupID as SetupID
	From
	(
		Select			[Delay]
					,	NTILE(10000) Over (Order By [Delay]) as NTilen
		From			Delays
		Where			SetupID = @SetupID
	) as d
	Group By NTilen
	Having NTilen In (10000, 9999, 9990, 9900)
)
--Then join with the info from testsetup and calculate the minimum distances to the rejector.
Select		sys.Product
		,	NTilen/100.0 as [Percentage]
		,	sys.ImageLength
		,	sys.SetupID
		,	sys.HardWare
		,	MaxDelay
		,	Case
				When sys.Product = 'Loose' Then
					MaxDelay*sys.ConvSpeed/1000 - 1250 --Rejector can start from the front of the image for loose
				Else									--ConvSpeed is in mm/s, delay is in ms so divide by 1000 to get in s, 1250 is the distance from the center to the end of conveyor.
					MaxDelay*sys.ConvSpeed/1000 - (1250 + sys.ImageLength) --Rejector can start from the end of the image for box or morphometry
				End as RejectorDistance
		,	sys.SystemID
		,	MaxDelay*sys.ConvSpeed/1000 - (750 + sys.ImageLength) as RejectorDistanceShort --The short MM2 is only for meat in boxes
From	DelayValues
Inner Join 
(
	Select		se.Product
			,	se.ImageLength
			,	sy.HardWare
			,	sy.SystemID
			,	se.SetupID
			,	se.ConvSpeed
	From	TestSetup se
	Inner Join	TestSystem sy
		On		sy.SystemID = se.SystemID
) as sys
	on	sys.SetupID = DelayValues.SetupID
)
GO
