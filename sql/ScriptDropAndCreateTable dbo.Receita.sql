USE [ControleFinanceiro]
GO

/****** Object: Table [dbo].[Receita] Script Date: 08/02/2023 21:53:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Receita];


GO
CREATE TABLE [dbo].[Receita] (
    [ReceitaId] INT           IDENTITY (1, 1) NOT NULL,
    [Descricao] VARCHAR (100) NOT NULL,
    [Valor]     DECIMAL (18)  NOT NULL,
    [Data]      DATETIME      NOT NULL
);


