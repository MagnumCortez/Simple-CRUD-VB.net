# Simple CRUD with VB.net

CREATE TABLE CATEGORIA

```
CREATE TABLE [dbo].[categorias](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
 CONSTRAINT [PK_categorias] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
```

CREATE TABLE PRODUTOS

```
CREATE TABLE [dbo].[produtos](
	[id_produto] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[id_categoria] [int] NOT NULL,
	[preco] [decimal](12, 2) NOT NULL,
 CONSTRAINT [PK_produto] PRIMARY KEY CLUSTERED 
(
	[id_produto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
```
