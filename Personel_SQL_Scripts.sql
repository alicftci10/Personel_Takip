USE [Personel]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 27.01.2025 16:52:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[Soyad] [nvarchar](50) NOT NULL,
	[TCNO] [nvarchar](50) NOT NULL,
	[KullaniciAdi] [nvarchar](50) NOT NULL,
	[Sifre] [nvarchar](50) NOT NULL,
	[Yetki] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Kullanici] ON 

INSERT [dbo].[Kullanici] ([Id], [Ad], [Soyad], [TCNO], [KullaniciAdi], [Sifre], [Yetki]) VALUES (1, N'Ali', N'Çiftçi', N'11111111111', N'admin', N'123', N'Yönetici')
INSERT [dbo].[Kullanici] ([Id], [Ad], [Soyad], [TCNO], [KullaniciAdi], [Sifre], [Yetki]) VALUES (2, N'deneme', N'test', N'22222222222', N'deneme', N'321', N'Personel')
SET IDENTITY_INSERT [dbo].[Kullanici] OFF
GO
