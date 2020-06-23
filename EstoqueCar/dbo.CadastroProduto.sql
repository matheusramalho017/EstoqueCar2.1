CREATE TABLE [dbo].[CadastroProduto]
(
	[IdProduto] INT NOT NULL PRIMARY KEY, 
    [NomeProduto] VARCHAR(50) NOT NULL, 
    [Modelo] VARCHAR(50) NOT NULL, 
    [Marca] VARCHAR(50) NOT NULL, 
    [Categoria] VARCHAR(50) NOT NULL, 
    [PreçoAdmissao] DECIMAL NOT NULL, 
    [PreçoVenda] DECIMAL NOT NULL
)
