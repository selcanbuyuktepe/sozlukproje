USE [sozlukselcan]
GO
/****** Object:  Table [dbo].[SozlukCeviri]    Script Date: 27.12.2018 14:30:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SozlukCeviri](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Turkce] [nvarchar](max) NULL,
	[İngilizce] [nvarchar](max) NULL,
	[trcumle] [nvarchar](max) NULL,
	[engcumle] [nvarchar](max) NULL,
 CONSTRAINT [PK_Ceviri] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SozlukCeviri] ON 

INSERT [dbo].[SozlukCeviri] ([Id], [Turkce], [İngilizce], [trcumle], [engcumle]) VALUES (1, N'altın', N'gold', N'altın aldım', N'
i got gold')
INSERT [dbo].[SozlukCeviri] ([Id], [Turkce], [İngilizce], [trcumle], [engcumle]) VALUES (6, N'cam', N'pine', N'camı kırdım', N'aaaa')
INSERT [dbo].[SozlukCeviri] ([Id], [Turkce], [İngilizce], [trcumle], [engcumle]) VALUES (7, N'siyah', N'black', N'siyah tshirt', N'black tshirt')
INSERT [dbo].[SozlukCeviri] ([Id], [Turkce], [İngilizce], [trcumle], [engcumle]) VALUES (8, N'pembe', N'pink', N'pembe', N'bhjnklş')
INSERT [dbo].[SozlukCeviri] ([Id], [Turkce], [İngilizce], [trcumle], [engcumle]) VALUES (9, N'araba', N' car', N' arabaya bindi', N'  get in the car')
INSERT [dbo].[SozlukCeviri] ([Id], [Turkce], [İngilizce], [trcumle], [engcumle]) VALUES (10, N'a', N'aa', N'a', N'a')
SET IDENTITY_INSERT [dbo].[SozlukCeviri] OFF
