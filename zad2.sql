/****** Object:  Table [dbo].[Pracowniks]    Script Date: 2023-03-20 15:23:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Pracowniks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Imie] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[Zadanies]    Script Date: 2023-03-20 15:24:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Zadanies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Kategoria] [varchar](255) NOT NULL,
	[Opis] [varchar](255) NOT NULL,
	[CzyZakonczone] [bit] NOT NULL,
	[PracownikId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Zadanies]  WITH CHECK ADD FOREIGN KEY([PracownikId])
REFERENCES [dbo].[Pracowniks] ([Id])
GO

