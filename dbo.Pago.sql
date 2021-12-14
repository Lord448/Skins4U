CREATE TABLE [dbo].[Table]
(
	[IDSuplidor] FLOAT NOT NULL PRIMARY KEY, 
    [Suplidor] TEXT NULL, 
    [Representante] VARCHAR(50) NULL,
	[Dirección] VARCHAR(100) NULL DEFAULT 'Activo'
)
