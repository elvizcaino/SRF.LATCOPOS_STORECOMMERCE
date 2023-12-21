-- Create the extension table to store the custom fields.
IF (SELECT OBJECT_ID('[ext].[LATCOBasicDocumentType]')) IS NULL 
BEGIN
    CREATE TABLE [ext].[LATCOBasicDocumentType]
    (
		[CheckDigitCal]     INT NOT NULL DEFAULT((0)),
        [Description] NVARCHAR(60) NOT NULL DEFAULT (('')),
		[DocumentCod] NVARCHAR(10) NOT NULL DEFAULT (('')),
		[DocumentId] NVARCHAR(60) NOT NULL DEFAULT (('')),
		[PlainTextDocumentType] NVARCHAR(60) NOT NULL DEFAULT (('')),
		[IsAlphanumeric]     INT NOT NULL DEFAULT((0)),
		[CampLong]     INT NOT NULL DEFAULT((0)),
		[Itau] NVARCHAR(10) NOT NULL DEFAULT (('')),
		[Davivienda] NVARCHAR(10) NOT NULL DEFAULT (('')),
		[BancoBogota] NVARCHAR(10) NOT NULL DEFAULT (('')),
		[ForeignDocument]     INT NOT NULL DEFAULT((0)),
		[DocumentCodRE] NVARCHAR(10) NOT NULL DEFAULT (('')),
		[RecId]     BIGINT NOT NULL DEFAULT((0)),
        [DataAreaId] [nvarchar] (4) NOT NULL DEFAULT(('DAT')),
	    [RowVersion] [timestamp] NOT NULL,
        CONSTRAINT [I_LATCOBasicDocumentType_RecId] PRIMARY KEY CLUSTERED 
        (
            [RecId] ASC
        ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
    ) ON [PRIMARY]
END
GO

GRANT SELECT, INSERT, UPDATE, DELETE ON OBJECT::[ext].[LATCOBasicDocumentType] TO [DataSyncUsersRole]
GO


-- Create the custom view that can query a complete Example Entity.
IF (SELECT OBJECT_ID('[ext].[LATCOBasicDocumentTypeView]')) IS NOT NULL
    DROP VIEW [ext].[LATCOBasicDocumentTypeView]
GO

CREATE VIEW [ext].[LATCOBasicDocumentTypeView] AS
(
    SELECT
		et.[CheckDigitCal],
		et.[Description],
		et.[DocumentCod],
		et.[DocumentId],
		et.[PlainTextDocumentType],
		et.[IsAlphanumeric],
		et.[CampLong],
		et.[Itau],
		et.[Davivienda],
		et.[BancoBogota],
		et.[ForeignDocument],
		et.[DocumentCodRE],
		et.[RecId],
        et.[DataAreaId]
    FROM
        [ext].[LATCOBasicDocumentType] et
)
GO

GRANT SELECT ON OBJECT::[ext].[LATCOBasicDocumentTypeView] TO [UsersRole];
GO

GRANT SELECT ON OBJECT::[ext].[LATCOBasicDocumentTypeView] TO [DeployExtensibilityRole];
GO