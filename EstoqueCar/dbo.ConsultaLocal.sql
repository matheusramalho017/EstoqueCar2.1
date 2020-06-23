CREATE TABLE [dbo].[ConsultaLocal]
(
	[IdPrateleira] INT NOT NULL PRIMARY KEY, 
    [Posicao] CHAR(10) NOT NULL, 
    [Disponibilidade] UNIQUEIDENTIFIER NOT NULL
)
