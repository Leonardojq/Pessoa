
USE [Pessoa]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Pessoa](
	[nr_cpf] [bigint] NOT NULL,
	[ds_nome] [varchar](255) NULL,
	[ds_sobrenome] [varchar](255) NULL,
	[ds_nacionalidade] [varchar](255) NULL,
	[nr_cep] [varchar](15) NULL,
	[ds_estado] [varchar](120) NULL,
	[ds_cidade] [varchar](255) NULL,
	[ds_logradouro] [varchar](450) NULL,
	[ds_email] [varchar](250) NULL,
	[nr_telefone] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[nr_cpf] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


