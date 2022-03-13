USE [master]
GO
/****** Object:  Database [Farmacia]    Script Date: 13/03/2022 01:20:28 ******/
CREATE DATABASE [Farmacia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Farmacia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Farmacia.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Farmacia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Farmacia_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Farmacia] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Farmacia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Farmacia] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Farmacia] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Farmacia] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Farmacia] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Farmacia] SET ARITHABORT OFF 
GO
ALTER DATABASE [Farmacia] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Farmacia] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Farmacia] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Farmacia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Farmacia] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Farmacia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Farmacia] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Farmacia] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Farmacia] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Farmacia] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Farmacia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Farmacia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Farmacia] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Farmacia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Farmacia] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Farmacia] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Farmacia] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Farmacia] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Farmacia] SET  MULTI_USER 
GO
ALTER DATABASE [Farmacia] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Farmacia] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Farmacia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Farmacia] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Farmacia] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Farmacia]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 13/03/2022 01:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[ID_CATEGORIA] [int] IDENTITY(1,1) NOT NULL,
	[NOME_CATEGORIA] [nvarchar](50) NOT NULL,
	[DESCRICAO_CATEGORIA] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_CATEGORIA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 13/03/2022 01:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ID_CLIENTE] [int] IDENTITY(1,1) NOT NULL,
	[NOME_CLIENTE] [nvarchar](50) NOT NULL,
	[ENDERECO] [nvarchar](50) NOT NULL,
	[BAIRRO] [nvarchar](30) NOT NULL,
	[CIDADE] [nvarchar](50) NOT NULL,
	[NASCIMENTO] [datetime] NOT NULL,
	[RG] [nvarchar](30) NOT NULL,
	[CPF] [nvarchar](25) NOT NULL,
	[TELEFONE] [nvarchar](15) NOT NULL,
	[CELULAR] [nvarchar](16) NULL,
	[OBSERVACAO] [nvarchar](max) NULL,
	[DATA_CADASTRO] [datetime] NOT NULL,
 CONSTRAINT [PK__Clientes__23A3413036EF8062] PRIMARY KEY CLUSTERED 
(
	[ID_CLIENTE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Detalhes_vendas]    Script Date: 13/03/2022 01:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalhes_vendas](
	[ID_DETALHES] [int] IDENTITY(1,1) NOT NULL,
	[ID_VENDA] [int] NOT NULL,
	[ID_PRODUTO] [int] NOT NULL,
	[QUANTIDADE] [int] NOT NULL,
 CONSTRAINT [PK__Detalhes__CCB83D73041EB62B] PRIMARY KEY CLUSTERED 
(
	[ID_DETALHES] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nivel_Acesso]    Script Date: 13/03/2022 01:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nivel_Acesso](
	[ID_NIVEL] [int] IDENTITY(1,1) NOT NULL,
	[NOME_NIVEL] [nvarchar](50) NOT NULL,
	[DESCRICAO_NIVEL] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK__Nivel_Ac__1C9E445D37DA9155] PRIMARY KEY CLUSTERED 
(
	[ID_NIVEL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Produtos]    Script Date: 13/03/2022 01:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produtos](
	[ID_PRODUTO] [int] IDENTITY(1,1) NOT NULL,
	[CODIGO_BARRAS] [nvarchar](50) NOT NULL,
	[DATA_CADASTRO] [datetime] NOT NULL,
	[NOME_PRODUTO] [nvarchar](50) NOT NULL,
	[DETALHES_PRODUTO] [nvarchar](50) NOT NULL,
	[ID_CATEGORIA] [int] NOT NULL,
	[ESTOQUE_MINIMO] [int] NOT NULL,
	[ESTOQUE_ATUAL] [int] NOT NULL,
	[VALOR_CUSTO] [decimal](6, 2) NOT NULL,
	[VALOR_VENDA] [decimal](6, 2) NOT NULL,
 CONSTRAINT [PK__Produtos__69B28A52F3B321A3] PRIMARY KEY CLUSTERED 
(
	[ID_PRODUTO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 13/03/2022 01:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID_USUARIO] [int] IDENTITY(1,1) NOT NULL,
	[NOME_USUARIO] [nvarchar](50) NOT NULL,
	[DATA_CADASTRO] [datetime] NOT NULL,
	[LOGIN_USUARIO] [nvarchar](40) NOT NULL,
	[SENHA_USUARIO] [nvarchar](40) NOT NULL,
	[STATUS_USUARIO] [nvarchar](15) NOT NULL,
	[ID_NIVEL] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_USUARIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vendas]    Script Date: 13/03/2022 01:20:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendas](
	[ID_VENDA] [int] IDENTITY(1,1) NOT NULL,
	[ID_USUARIO] [int] NOT NULL,
	[ID_CLIENTE] [int] NOT NULL,
	[DATA_VENDA] [datetime] NOT NULL,
	[SITUACAO] [bit] NOT NULL,
 CONSTRAINT [PK__Vendas__F3B65F8877A7EAF5] PRIMARY KEY CLUSTERED 
(
	[ID_VENDA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Categorias] ON 

INSERT [dbo].[Categorias] ([ID_CATEGORIA], [NOME_CATEGORIA], [DESCRICAO_CATEGORIA]) VALUES (1, N'Medicamentos', N'Medicamentos em geral.')
INSERT [dbo].[Categorias] ([ID_CATEGORIA], [NOME_CATEGORIA], [DESCRICAO_CATEGORIA]) VALUES (2, N'Higiene', N'Produtos com higiene pessoal')
INSERT [dbo].[Categorias] ([ID_CATEGORIA], [NOME_CATEGORIA], [DESCRICAO_CATEGORIA]) VALUES (3, N'Cosméticos', N'Cosméticos em geral')
INSERT [dbo].[Categorias] ([ID_CATEGORIA], [NOME_CATEGORIA], [DESCRICAO_CATEGORIA]) VALUES (4, N'Suplementos', N'Suplementos alimentares')
INSERT [dbo].[Categorias] ([ID_CATEGORIA], [NOME_CATEGORIA], [DESCRICAO_CATEGORIA]) VALUES (5, N'Bijuteria', N'Bijuteria em geral')
INSERT [dbo].[Categorias] ([ID_CATEGORIA], [NOME_CATEGORIA], [DESCRICAO_CATEGORIA]) VALUES (6, N'Perfumaria', N'Perfumaria em geral')
SET IDENTITY_INSERT [dbo].[Categorias] OFF
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([ID_CLIENTE], [NOME_CLIENTE], [ENDERECO], [BAIRRO], [CIDADE], [NASCIMENTO], [RG], [CPF], [TELEFONE], [CELULAR], [OBSERVACAO], [DATA_CADASTRO]) VALUES (1, N'Gabriel Moura', N'Rua 15 de Novembro, 2139', N'Jardim', N'Santos', CAST(N'1987-12-14 00:00:00.000' AS DateTime), N'78.945.612-3', N'582.613.866-19', N'(14) 7895-3525', N'(14) 78845-6322', N'Possui interesse em ofertas de suplementos', CAST(N'2021-09-09 00:00:00.000' AS DateTime))
INSERT [dbo].[Clientes] ([ID_CLIENTE], [NOME_CLIENTE], [ENDERECO], [BAIRRO], [CIDADE], [NASCIMENTO], [RG], [CPF], [TELEFONE], [CELULAR], [OBSERVACAO], [DATA_CADASTRO]) VALUES (2, N'', N'', N'', N'', CAST(N'2021-09-09 00:00:00.000' AS DateTime), N'  .   .   -', N'   .   .   -', N'(  )     -', N'(  )      -', N'', CAST(N'2021-09-09 00:00:00.000' AS DateTime))
INSERT [dbo].[Clientes] ([ID_CLIENTE], [NOME_CLIENTE], [ENDERECO], [BAIRRO], [CIDADE], [NASCIMENTO], [RG], [CPF], [TELEFONE], [CELULAR], [OBSERVACAO], [DATA_CADASTRO]) VALUES (3, N'Maria Aparecida da Silva Santos', N'Rua do Saber, 123', N'Avenida Brasil', N'Itapeva', CAST(N'1980-12-09 00:00:00.000' AS DateTime), N'33.991.177-4', N'617.665.040-27', N'(15) 9876-5432', N'(  )      -', N'Somente a cliente pagará produtos em sua conta', CAST(N'2021-09-10 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Clientes] OFF
SET IDENTITY_INSERT [dbo].[Nivel_Acesso] ON 

INSERT [dbo].[Nivel_Acesso] ([ID_NIVEL], [NOME_NIVEL], [DESCRICAO_NIVEL]) VALUES (1, N'Administrador', N'Tem controle total do sistema.')
INSERT [dbo].[Nivel_Acesso] ([ID_NIVEL], [NOME_NIVEL], [DESCRICAO_NIVEL]) VALUES (2, N'Gerente', N'Só não consegue cadastrar novos usuários.')
INSERT [dbo].[Nivel_Acesso] ([ID_NIVEL], [NOME_NIVEL], [DESCRICAO_NIVEL]) VALUES (3, N'Balconista', N'Responsável pelas vendas. Não consegue abrir e fechar o caixa.')
INSERT [dbo].[Nivel_Acesso] ([ID_NIVEL], [NOME_NIVEL], [DESCRICAO_NIVEL]) VALUES (4, N'Conferente', N'Responsável pelo cadastro de produtos e atualização de estoque.')
SET IDENTITY_INSERT [dbo].[Nivel_Acesso] OFF
SET IDENTITY_INSERT [dbo].[Produtos] ON 

INSERT [dbo].[Produtos] ([ID_PRODUTO], [CODIGO_BARRAS], [DATA_CADASTRO], [NOME_PRODUTO], [DETALHES_PRODUTO], [ID_CATEGORIA], [ESTOQUE_MINIMO], [ESTOQUE_ATUAL], [VALOR_CUSTO], [VALOR_VENDA]) VALUES (1, N'1234567899876', CAST(N'2021-09-14 00:00:00.000' AS DateTime), N'Aspirina', N'env 4 comp', 1, 10, 15, CAST(2.90 AS Decimal(6, 2)), CAST(4.95 AS Decimal(6, 2)))
INSERT [dbo].[Produtos] ([ID_PRODUTO], [CODIGO_BARRAS], [DATA_CADASTRO], [NOME_PRODUTO], [DETALHES_PRODUTO], [ID_CATEGORIA], [ESTOQUE_MINIMO], [ESTOQUE_ATUAL], [VALOR_CUSTO], [VALOR_VENDA]) VALUES (2, N'5874123698525', CAST(N'2021-09-14 00:00:00.000' AS DateTime), N'Doril', N'env 8 comp', 1, 10, 30, CAST(2.25 AS Decimal(6, 2)), CAST(5.50 AS Decimal(6, 2)))
INSERT [dbo].[Produtos] ([ID_PRODUTO], [CODIGO_BARRAS], [DATA_CADASTRO], [NOME_PRODUTO], [DETALHES_PRODUTO], [ID_CATEGORIA], [ESTOQUE_MINIMO], [ESTOQUE_ATUAL], [VALOR_CUSTO], [VALOR_VENDA]) VALUES (3, N'8426951379632', CAST(N'2021-09-14 00:00:00.000' AS DateTime), N'Escova de dente', N'unidade', 2, 10, 18, CAST(1.50 AS Decimal(6, 2)), CAST(5.00 AS Decimal(6, 2)))
INSERT [dbo].[Produtos] ([ID_PRODUTO], [CODIGO_BARRAS], [DATA_CADASTRO], [NOME_PRODUTO], [DETALHES_PRODUTO], [ID_CATEGORIA], [ESTOQUE_MINIMO], [ESTOQUE_ATUAL], [VALOR_CUSTO], [VALOR_VENDA]) VALUES (4, N'9631478526988', CAST(N'2021-09-14 00:00:00.000' AS DateTime), N'Naldecon', N'env 4 comp', 1, 15, 30, CAST(5.00 AS Decimal(6, 2)), CAST(7.25 AS Decimal(6, 2)))
INSERT [dbo].[Produtos] ([ID_PRODUTO], [CODIGO_BARRAS], [DATA_CADASTRO], [NOME_PRODUTO], [DETALHES_PRODUTO], [ID_CATEGORIA], [ESTOQUE_MINIMO], [ESTOQUE_ATUAL], [VALOR_CUSTO], [VALOR_VENDA]) VALUES (5, N'9876543211234', CAST(N'2021-09-14 00:00:00.000' AS DateTime), N'Neosaldina', N'env 4 comp', 1, 15, 50, CAST(2.00 AS Decimal(6, 2)), CAST(5.89 AS Decimal(6, 2)))
INSERT [dbo].[Produtos] ([ID_PRODUTO], [CODIGO_BARRAS], [DATA_CADASTRO], [NOME_PRODUTO], [DETALHES_PRODUTO], [ID_CATEGORIA], [ESTOQUE_MINIMO], [ESTOQUE_ATUAL], [VALOR_CUSTO], [VALOR_VENDA]) VALUES (6, N'9632587411234', CAST(N'2021-09-14 00:00:00.000' AS DateTime), N'Tilenol', N'cx 15 comp', 1, 10, 20, CAST(4.50 AS Decimal(6, 2)), CAST(8.50 AS Decimal(6, 2)))
INSERT [dbo].[Produtos] ([ID_PRODUTO], [CODIGO_BARRAS], [DATA_CADASTRO], [NOME_PRODUTO], [DETALHES_PRODUTO], [ID_CATEGORIA], [ESTOQUE_MINIMO], [ESTOQUE_ATUAL], [VALOR_CUSTO], [VALOR_VENDA]) VALUES (7, N'9632147852365', CAST(N'2021-09-14 00:00:00.000' AS DateTime), N'Rivotril', N'emb 25ml', 1, 8, 15, CAST(10.00 AS Decimal(6, 2)), CAST(18.60 AS Decimal(6, 2)))
INSERT [dbo].[Produtos] ([ID_PRODUTO], [CODIGO_BARRAS], [DATA_CADASTRO], [NOME_PRODUTO], [DETALHES_PRODUTO], [ID_CATEGORIA], [ESTOQUE_MINIMO], [ESTOQUE_ATUAL], [VALOR_CUSTO], [VALOR_VENDA]) VALUES (8, N'6523417899870', CAST(N'2021-09-14 00:00:00.000' AS DateTime), N'Sabonete', N'emb 100ml', 2, 15, 20, CAST(3.00 AS Decimal(6, 2)), CAST(8.50 AS Decimal(6, 2)))
INSERT [dbo].[Produtos] ([ID_PRODUTO], [CODIGO_BARRAS], [DATA_CADASTRO], [NOME_PRODUTO], [DETALHES_PRODUTO], [ID_CATEGORIA], [ESTOQUE_MINIMO], [ESTOQUE_ATUAL], [VALOR_CUSTO], [VALOR_VENDA]) VALUES (9, N'6548912354687', CAST(N'2021-09-14 00:00:00.000' AS DateTime), N'Shampoo', N'emb 250ml', 2, 5, 2, CAST(7.50 AS Decimal(6, 2)), CAST(13.00 AS Decimal(6, 2)))
INSERT [dbo].[Produtos] ([ID_PRODUTO], [CODIGO_BARRAS], [DATA_CADASTRO], [NOME_PRODUTO], [DETALHES_PRODUTO], [ID_CATEGORIA], [ESTOQUE_MINIMO], [ESTOQUE_ATUAL], [VALOR_CUSTO], [VALOR_VENDA]) VALUES (10, N'6985632145698', CAST(N'2021-09-14 00:00:00.000' AS DateTime), N'Whey Protein', N'unidade', 4, 5, 4, CAST(80.00 AS Decimal(6, 2)), CAST(120.00 AS Decimal(6, 2)))
SET IDENTITY_INSERT [dbo].[Produtos] OFF
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([ID_USUARIO], [NOME_USUARIO], [DATA_CADASTRO], [LOGIN_USUARIO], [SENHA_USUARIO], [STATUS_USUARIO], [ID_NIVEL]) VALUES (1, N'Lucane Visual Studio', CAST(N'2021-09-18 00:00:00.000' AS DateTime), N'Lucane', N'123', N'Ativo', 1)
INSERT [dbo].[Usuarios] ([ID_USUARIO], [NOME_USUARIO], [DATA_CADASTRO], [LOGIN_USUARIO], [SENHA_USUARIO], [STATUS_USUARIO], [ID_NIVEL]) VALUES (2, N'João Almeida', CAST(N'2021-09-18 00:00:00.000' AS DateTime), N'João', N'1234567', N'Ativo', 2)
INSERT [dbo].[Usuarios] ([ID_USUARIO], [NOME_USUARIO], [DATA_CADASTRO], [LOGIN_USUARIO], [SENHA_USUARIO], [STATUS_USUARIO], [ID_NIVEL]) VALUES (3, N'Antônio McValdés', CAST(N'2021-09-27 00:00:00.000' AS DateTime), N'Antônio', N'123', N'Ativo', 4)
INSERT [dbo].[Usuarios] ([ID_USUARIO], [NOME_USUARIO], [DATA_CADASTRO], [LOGIN_USUARIO], [SENHA_USUARIO], [STATUS_USUARIO], [ID_NIVEL]) VALUES (4, N'Patricia Boeira', CAST(N'2021-09-27 00:00:00.000' AS DateTime), N'Tricia', N'tricia', N'Ativo', 3)
INSERT [dbo].[Usuarios] ([ID_USUARIO], [NOME_USUARIO], [DATA_CADASTRO], [LOGIN_USUARIO], [SENHA_USUARIO], [STATUS_USUARIO], [ID_NIVEL]) VALUES (5, N'Novo Usuario', CAST(N'2021-09-28 00:00:00.000' AS DateTime), N'novoUsuario', N'NTY3', N'Ativo', 1)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
ALTER TABLE [dbo].[Detalhes_vendas]  WITH CHECK ADD  CONSTRAINT [FK_Detalhes_vendas_Vendas] FOREIGN KEY([ID_VENDA])
REFERENCES [dbo].[Vendas] ([ID_VENDA])
GO
ALTER TABLE [dbo].[Detalhes_vendas] CHECK CONSTRAINT [FK_Detalhes_vendas_Vendas]
GO
ALTER TABLE [dbo].[Nivel_Acesso]  WITH CHECK ADD  CONSTRAINT [FK_Nivel_Acesso_Nivel_Acesso] FOREIGN KEY([ID_NIVEL])
REFERENCES [dbo].[Nivel_Acesso] ([ID_NIVEL])
GO
ALTER TABLE [dbo].[Nivel_Acesso] CHECK CONSTRAINT [FK_Nivel_Acesso_Nivel_Acesso]
GO
ALTER TABLE [dbo].[Produtos]  WITH CHECK ADD  CONSTRAINT [FK_Produtos_Categorias] FOREIGN KEY([ID_CATEGORIA])
REFERENCES [dbo].[Categorias] ([ID_CATEGORIA])
GO
ALTER TABLE [dbo].[Produtos] CHECK CONSTRAINT [FK_Produtos_Categorias]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Nivel_Acesso] FOREIGN KEY([ID_NIVEL])
REFERENCES [dbo].[Nivel_Acesso] ([ID_NIVEL])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Nivel_Acesso]
GO
ALTER TABLE [dbo].[Vendas]  WITH CHECK ADD  CONSTRAINT [FK_Vendas_Clientes] FOREIGN KEY([ID_CLIENTE])
REFERENCES [dbo].[Clientes] ([ID_CLIENTE])
GO
ALTER TABLE [dbo].[Vendas] CHECK CONSTRAINT [FK_Vendas_Clientes]
GO
ALTER TABLE [dbo].[Vendas]  WITH CHECK ADD  CONSTRAINT [FK_Vendas_Usuarios] FOREIGN KEY([ID_USUARIO])
REFERENCES [dbo].[Usuarios] ([ID_USUARIO])
GO
ALTER TABLE [dbo].[Vendas] CHECK CONSTRAINT [FK_Vendas_Usuarios]
GO
USE [master]
GO
ALTER DATABASE [Farmacia] SET  READ_WRITE 
GO
