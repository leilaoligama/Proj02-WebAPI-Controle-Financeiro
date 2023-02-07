CREATE TABLE [dbo].Despesa
(
	[DespesaId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Descricao] VARCHAR(100) NULL, 
    [Valor] DECIMAL NOT NULL, 
    [Data] DATETIME NOT NULL
)
