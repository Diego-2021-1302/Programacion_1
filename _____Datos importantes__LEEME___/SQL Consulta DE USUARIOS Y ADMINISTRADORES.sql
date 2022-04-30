/****** Este script lo genero la PC porque el que yo cree esta en otra que vendi ******/


USE [FGP]
GO
/****** Object:  StoredProcedure [dbo].[SP_MOSTRARTABLACLIENTES]    Script Date: 08/03/2022 13:30:23 ******/
DROP PROCEDURE IF EXISTS [dbo].[SP_MOSTRARTABLACLIENTES]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 08/03/2022 13:30:23 ******/
DROP TABLE IF EXISTS [dbo].[Usuarios]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 08/03/2022 13:30:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Cedula] [varchar](13) NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Apellido] [varchar](30) NOT NULL,
	[Fecha_Nacimiento] [varchar](20) NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Num_Telefono] [varchar](12) NOT NULL,
	[Email] [varchar](40) NOT NULL,
	[Nom_Usuario] [varchar](15) NOT NULL,
	[Contraseña] [varchar](18) NOT NULL,
	[Tipo_Usuario] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Usuarios] ([Cedula], [Nombre], [Apellido], [Fecha_Nacimiento], [Direccion], [Num_Telefono], [Email], [Nom_Usuario], [Contraseña], [Tipo_Usuario]) VALUES (N'055-0010616-5', N'Dhariana', N'de Jesús Valerio', N'25 Diciembre 1999', N'Los coquitos calle 3 casa #40', N'829-462-6481', N'copias2@gmail.com', N'Dhariana', N'1532', N'Usuario')
GO
INSERT [dbo].[Usuarios] ([Cedula], [Nombre], [Apellido], [Fecha_Nacimiento], [Direccion], [Num_Telefono], [Email], [Nom_Usuario], [Contraseña], [Tipo_Usuario]) VALUES (N'055-0019711-5', N'Damaris María', N'Amparo', N'5 Enero2002', N'Calle El sol #9', N'829-942-6484', N'yendy92@hotmail.com', N'Damaris', N'0515', N'Usuario')
GO
INSERT [dbo].[Usuarios] ([Cedula], [Nombre], [Apellido], [Fecha_Nacimiento], [Direccion], [Num_Telefono], [Email], [Nom_Usuario], [Contraseña], [Tipo_Usuario]) VALUES (N'055-0020268-3', N'Carlos Enmanuel', N'Gil Burgos', N'7 Julio 2001', N'Calle 3 Esq 5 parte atras, casa #32', N'829-468-4621', N'genaromall@gmail.com', N'Carlos', N'2525', N'Usuario')
GO
INSERT [dbo].[Usuarios] ([Cedula], [Nombre], [Apellido], [Fecha_Nacimiento], [Direccion], [Num_Telefono], [Email], [Nom_Usuario], [Contraseña], [Tipo_Usuario]) VALUES (N'055-0022688-0', N'Danilo Miguel', N'Portorreal', N'21 Marzo 1998', N'Calle pluton esq Marte, Casa 20', N'809-464-6644', N'98ingenieria@gmail.com', N'Danilo', N'2613', N'Usuario')
GO
INSERT [dbo].[Usuarios] ([Cedula], [Nombre], [Apellido], [Fecha_Nacimiento], [Direccion], [Num_Telefono], [Email], [Nom_Usuario], [Contraseña], [Tipo_Usuario]) VALUES (N'055-0024836-3', N'Dorca', N'Martínez Acevedo', N'20 Octubre 1998', N'Calle los Cerros. 4ha esquina casa #35', N'829-138-7588', N'3ases@3aseseg.com', N'Dorca', N'3013', N'Usuario')
GO
INSERT [dbo].[Usuarios] ([Cedula], [Nombre], [Apellido], [Fecha_Nacimiento], [Direccion], [Num_Telefono], [Email], [Nom_Usuario], [Contraseña], [Tipo_Usuario]) VALUES (N'055-0026861-9', N'Isaac Rafael', N'Garabito Rosa', N'17 Noviembre 2000', N'Calle 2 Residencial Popiluco #40', N'829-157-1472', N'egomez@gmail.com', N'Papotico', N'1482', N'Administrador')
GO
INSERT [dbo].[Usuarios] ([Cedula], [Nombre], [Apellido], [Fecha_Nacimiento], [Direccion], [Num_Telefono], [Email], [Nom_Usuario], [Contraseña], [Tipo_Usuario]) VALUES (N'055-0026889-0', N'Dawerky', N'Mercedez Lopez', N'16 Octubre 2002', N'12, Esq 13. Casa Sn', N'809-254-4654', N'gperez@2020@gmail.com', N'Dawerky', N'0123', N'Administrador')
GO
INSERT [dbo].[Usuarios] ([Cedula], [Nombre], [Apellido], [Fecha_Nacimiento], [Direccion], [Num_Telefono], [Email], [Nom_Usuario], [Contraseña], [Tipo_Usuario]) VALUES (N'402-1459267-0', N'Diego Esmerlin', N'Garabito Brito', N'16 Septiembre 2001', N'12, Esq 13. Casa 32', N'829-285-7879', N'Diegoesmerlingarabito@hotmail.com,', N'Diego', N'2120', N'Administrador')
GO
INSERT [dbo].[Usuarios] ([Cedula], [Nombre], [Apellido], [Fecha_Nacimiento], [Direccion], [Num_Telefono], [Email], [Nom_Usuario], [Contraseña], [Tipo_Usuario]) VALUES (N'402-2376925-4', N'Dayana Miguelina', N'Abreu Santos', N'30 Septiembre 1996', N'Los coquitos calle 3 casa #40', N'829-249-1541', N'm4controldeplagas@hotmail.com', N'Dayana', N'1131', N'Usuario')
GO
INSERT [dbo].[Usuarios] ([Cedula], [Nombre], [Apellido], [Fecha_Nacimiento], [Direccion], [Num_Telefono], [Email], [Nom_Usuario], [Contraseña], [Tipo_Usuario]) VALUES (N'402-2505339-2', N'Erickson', N'Martínez Acevedo', N'15 Abril 1997', N'Calle 252. Casa #15', N'829-465-2872', N'timportaciones@gmail.com', N'Erickson', N'0146', N'Usuario')
GO
INSERT [dbo].[Usuarios] ([Cedula], [Nombre], [Apellido], [Fecha_Nacimiento], [Direccion], [Num_Telefono], [Email], [Nom_Usuario], [Contraseña], [Tipo_Usuario]) VALUES (N'402-3794442-2', N'Maria Efigenia', N'Taveras Abreu', N'12 Mayo 1994', N'Calle 132 casa #20', N'849-124-4304', N'basilia@gmail.com', N'Maria', N'1531', N'Usuario')
GO
/****** Object:  StoredProcedure [dbo].[SP_MOSTRARTABLACLIENTES]    Script Date: 08/03/2022 13:30:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[SP_MOSTRARTABLACLIENTES]
AS
Select * from Usuarios
GO