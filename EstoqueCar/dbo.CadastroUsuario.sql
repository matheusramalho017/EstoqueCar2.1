CREATE TABLE [dbo].[CadastroUsuario] (
    [id]           INT          NOT NULL,
    [usuario] VARCHAR (50) NOT NULL,
    [email]   VARCHAR (50) NOT NULL,
    [dataNasc]     VARCHAR (50) NULL,
    [senha]        VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

