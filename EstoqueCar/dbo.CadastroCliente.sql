CREATE TABLE [dbo].[CadastroCliente] (
    [IdCliente]      INT          NOT NULL,
    [primeiroNome]   VARCHAR (50) NOT NULL,
    [ultimoNome]     VARCHAR (50) NOT NULL,
    [dataNascimento] VARCHAR (50) NOT NULL,
    [senha]          VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([IdCliente] ASC)
);

