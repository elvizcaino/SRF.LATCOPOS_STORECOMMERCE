﻿GRANT SELECT, INSERT, UPDATE, DELETE ON OBJECT::[ax].[CustTable] TO [DataSyncUsersRole]
GO

ALTER TABLE [ax].[CustTable]
ADD [LATCOOBLIGATIONCODE] NVARCHAR(10) NOT NULL DEFAULT ((''))
GO

ALTER TABLE [ax].[CustTable]
ADD [LATCOACTIVITYCIIUID] NVARCHAR(20) NOT NULL DEFAULT ((''))
GO

ALTER TABLE [ax].[CustTable]
ADD [LATCOCONTRIBUTORTYPE] NVARCHAR(20) NOT NULL DEFAULT ((''))
GO

ALTER TABLE [ax].[CustTable]
ADD [LATCODIGITNUM] NVARCHAR(1) NOT NULL DEFAULT ((''))
GO

ALTER TABLE [ax].[CustTable]
ADD [LATCODOCUMENTTYPE] NVARCHAR(15) NOT NULL DEFAULT ((''))
GO

ALTER TABLE [ax].[CustTable]
ADD [LATCOIVAREGIME] NVARCHAR(60) NOT NULL DEFAULT ((''))
GO

IF (SELECT OBJECT_ID('[ext].[CustTableView]')) IS NOT NULL
    DROP VIEW [ext].[CustTableView]
GO
CREATE VIEW [ext].[CustTableView] AS
(
    SELECT
		ct.[ACCOUNTNUM],
        ct.[LATCOACTIVITYCIIUID],
		ct.[LATCOCONTRIBUTORTYPE],
		ct.[LATCOOBLIGATIONCODE],
		ct.[LATCODIGITNUM],
		ct.[LATCODOCUMENTTYPE],
		ct.[LATCOIVAREGIME],
		ct.[IDENTIFICATIONNUMBER],
        ct.[DATAAREAID],
		ct.[RECID]
    FROM
        [ax].[CUSTTABLE] ct
)
GO

CREATE PROCEDURE [ext].[CustTableUpdate]
    @ACCOUNTNUM NVARCHAR(20),
	@LATCOACTIVITYCIIUID NVARCHAR(20),
	@LATCOCONTRIBUTORTYPE NVARCHAR(20),
	@LATCOOBLIGATIONCODE NVARCHAR(10),
	--@LATCODigitNum NVARCHAR(1),
	@LATCODOCUMENTTYPE NVARCHAR(15),
	@LATCOIVAREGIME NVARCHAR(60),
	@IDENTIFICATIONNUMBER NVARCHAR(50),
	@DATAAREAID NVARCHAR(4)
AS
BEGIN
    SET NOCOUNT ON

	DECLARE @recordsCount INT
	SELECT @recordsCount = COUNT(ACCOUNTNUM) FROM [AX].[CUSTTABLE] ct WHERE ct.ACCOUNTNUM = @ACCOUNTNUM;


	IF (@recordsCount > 0)
	BEGIN
		UPDATE [AX].[CUSTTABLE]
		SET LATCOCONTRIBUTORTYPE = @LATCOCONTRIBUTORTYPE,
		LATCOACTIVITYCIIUID = @LATCOACTIVITYCIIUID,
		LATCODOCUMENTTYPE = @LATCODOCUMENTTYPE,
		LATCOOBLIGATIONCODE = @LATCOOBLIGATIONCODE,
		LATCOIVAREGIME = @LATCOIVAREGIME,
		IDENTIFICATIONNUMBER = @IDENTIFICATIONNUMBER
		WHERE ACCOUNTNUM = @ACCOUNTNUM;
	END	
END;
GO

GRANT EXECUTE ON [ext].[CustTableUpdate] TO [UsersRole];
GO

GRANT EXECUTE ON [ext].[CustTableUpdate] TO [DeployExtensibilityRole];
GO