CREATE DATABASE [Nubitest]
GO

USE [Nubitest]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 24/07/2019 23:49:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [uniqueidentifier] NOT NULL,
	[Nombre] [varchar](150) NULL,
	[Apellido] [varchar](150) NULL,
	[Email] [varchar](150) NULL,
	[Password] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Users] ([Id], [Nombre], [Apellido], [Email], [Password]) VALUES (N'b6accdb9-c596-4325-ba05-6a5b72dd214d', N'Juana', N'De Arco', N'juanadearco@gmail.com', N'123456')
INSERT [dbo].[Users] ([Id], [Nombre], [Apellido], [Email], [Password]) VALUES (N'fcf73829-9e18-46e8-9a43-baea79b230c7', N'Yamil', N'Cussi', N'yamil.cussi@gmail.com', N'12345678')
INSERT [dbo].[Users] ([Id], [Nombre], [Apellido], [Email], [Password]) VALUES (N'6475e51d-b3d8-4ced-bbd1-db386e5efee6', N'Ana', N'Frank', N'ana.frank@gmail.com', N'123456')
INSERT [dbo].[Users] ([Id], [Nombre], [Apellido], [Email], [Password]) VALUES (N'a645bf58-07c0-4c81-8a14-e69fbdcfee16', N'Juana', N'De Arco', N'juanadearco@gmail.com', N'123456')
INSERT [dbo].[Users] ([Id], [Nombre], [Apellido], [Email], [Password]) VALUES (N'af42ca31-57e9-4c95-9293-ec0a3346d693', N'Julio', N'Diaz', N'julio.diaz@gmail.com', N'123456')
INSERT [dbo].[Users] ([Id], [Nombre], [Apellido], [Email], [Password]) VALUES (N'e7e01130-1c34-4941-8960-f5fd9c123594', N'Juana', N'De Arco', N'juanadearco@gmail.com', N'123456')
ALTER TABLE [dbo].[Users] ADD  DEFAULT (newid()) FOR [Id]
GO
