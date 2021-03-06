USE [master]
GO
/****** Object:  Database [SistemaVentas]    Script Date: 21/11/2018 17:57:03 ******/
CREATE DATABASE [SistemaVentas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SistemaVentas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SistemaVentas.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SistemaVentas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SistemaVentas_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SistemaVentas] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SistemaVentas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SistemaVentas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SistemaVentas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SistemaVentas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SistemaVentas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SistemaVentas] SET ARITHABORT OFF 
GO
ALTER DATABASE [SistemaVentas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SistemaVentas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SistemaVentas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SistemaVentas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SistemaVentas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SistemaVentas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SistemaVentas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SistemaVentas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SistemaVentas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SistemaVentas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SistemaVentas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SistemaVentas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SistemaVentas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SistemaVentas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SistemaVentas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SistemaVentas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SistemaVentas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SistemaVentas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SistemaVentas] SET  MULTI_USER 
GO
ALTER DATABASE [SistemaVentas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SistemaVentas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SistemaVentas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SistemaVentas] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SistemaVentas] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SistemaVentas', N'ON'
GO
USE [SistemaVentas]
GO
/****** Object:  Table [dbo].[Backups]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Backups](
	[ID_BackUp] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion_backup] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Backup] PRIMARY KEY CLUSTERED 
(
	[ID_BackUp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bitacora](
	[ID_Bitacora] [int] IDENTITY(1,1) NOT NULL,
	[ID_Usuario] [int] NOT NULL,
	[Evento] [varchar](250) NOT NULL,
	[Descripcion_bitacora] [varchar](250) NULL,
	[Fecha_Hora] [datetime] NOT NULL,
	[Criticidad] [varchar](50) NOT NULL,
	[DVH] [int] NOT NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[ID_Bitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria](
	[ID_Categoria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Categoria] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[ID_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[ID_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](250) NOT NULL,
	[Apellido] [varchar](250) NOT NULL,
	[DNI] [varchar](8) NOT NULL,
	[Mail] [varchar](250) NOT NULL,
	[DVH] [int] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[ID_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Detalle_Venta]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Venta](
	[ID_detalle_venta] [int] IDENTITY(1,1) NOT NULL,
	[ID_Venta] [int] NOT NULL,
	[ID_Producto] [int] NOT NULL,
	[Cantidad] [decimal](18, 2) NOT NULL,
	[Precio_unitario] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Detalle_Venta] PRIMARY KEY CLUSTERED 
(
	[ID_detalle_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DVV]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DVV](
	[Nombre_Tabla] [varchar](250) NOT NULL,
	[DVV] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Error]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Error](
	[ID_Error] [int] NOT NULL,
	[Descripcion_error] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Error] PRIMARY KEY CLUSTERED 
(
	[ID_Error] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Familia]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Familia](
	[ID_Familia] [int] NOT NULL,
	[Nombre_familia] [varchar](250) NOT NULL,
	[Descripcion_familia] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Familia] PRIMARY KEY CLUSTERED 
(
	[ID_Familia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Familia_Usuario]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Familia_Usuario](
	[ID_Usuario] [int] NOT NULL,
	[ID_Familia] [int] NOT NULL,
	[Descripcion_familia_usuario] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Familia_Usuario] PRIMARY KEY CLUSTERED 
(
	[ID_Usuario] ASC,
	[ID_Familia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Idioma]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Idioma](
	[ID_Idioma] [int] NOT NULL,
	[Nombre_idioma] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Idioma] PRIMARY KEY CLUSTERED 
(
	[ID_Idioma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mensajes]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mensajes](
	[ID_Mensaje] [int] NOT NULL,
	[ID_Idioma] [int] NOT NULL,
	[Nombre_control] [varchar](250) NOT NULL,
	[Nombre_formulario] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Mensajes] PRIMARY KEY CLUSTERED 
(
	[ID_Mensaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Patente]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Patente](
	[ID_Patente] [int] NOT NULL,
	[Nombre_patente] [varchar](250) NOT NULL,
	[Condicion] [varchar](250) NOT NULL,
	[DVH] [int] NOT NULL,
 CONSTRAINT [PK_Patente] PRIMARY KEY CLUSTERED 
(
	[ID_Patente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Patente_Familia]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patente_Familia](
	[ID_Patente] [int] NOT NULL,
	[ID_Familia] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
	[DVH] [int] NOT NULL,
 CONSTRAINT [PK_Patente_Familia] PRIMARY KEY CLUSTERED 
(
	[ID_Patente] ASC,
	[ID_Familia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Producto]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[ID_Producto] [int] IDENTITY(1,1) NOT NULL,
	[ID_Categoria] [int] NOT NULL,
	[ID_Reserva] [int] NULL,
	[Descripcion] [varchar](250) NULL,
	[Nombre_Producto] [varchar](250) NOT NULL,
	[Stock] [decimal](18, 2) NOT NULL,
	[Precio_Compra] [decimal](18, 2) NOT NULL,
	[Precio_Venta] [decimal](18, 2) NOT NULL,
	[imagen] [image] NULL,
	[DVH] [int] NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Restore]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Restore](
	[ID_Restore] [int] NOT NULL,
	[Descripcion_restore] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Restore] PRIMARY KEY CLUSTERED 
(
	[ID_Restore] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[ID_Usuario] [int] NOT NULL,
	[Nombre_Usuario] [varchar](250) NOT NULL,
	[Contraseña_usuario] [varchar](30) NOT NULL,
	[Nick_Usuario] [varchar](250) NOT NULL,
	[Bloqueo] [bit] NOT NULL,
	[DNI] [int] NOT NULL,
	[Mail] [varchar](250) NOT NULL,
	[Idioma] [int] NOT NULL,
	[DVH] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[ID_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario_Patente]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario_Patente](
	[ID_Usuario] [int] NOT NULL,
	[ID_Patente] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
	[DVH] [int] NOT NULL,
 CONSTRAINT [PK_Usuario_Patente] PRIMARY KEY CLUSTERED 
(
	[ID_Usuario] ASC,
	[ID_Patente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Venta]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Venta](
	[ID_Venta] [int] IDENTITY(1,1) NOT NULL,
	[ID_Cliente] [int] NOT NULL,
	[Fecha_Venta] [date] NOT NULL,
	[Tipo] [varchar](250) NOT NULL,
	[DNI] [varchar](8) NOT NULL,
	[Nro_Factura] [int] NULL,
	[DVH] [int] NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[ID_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[View_1]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_1]
AS
SELECT        dbo.Venta.ID_Venta, dbo.Venta.ID_Cliente, dbo.Cliente.Apellido, dbo.Cliente.DNI, dbo.Venta.Fecha_Venta, dbo.Venta.Tipo, dbo.Venta.DNI AS Expr1, dbo.Venta.Nro_Factura
FROM            dbo.Venta INNER JOIN
                         dbo.Cliente ON dbo.Venta.ID_Cliente = dbo.Cliente.ID_Cliente


GO
/****** Object:  View [dbo].[View_2]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_2]
AS
SELECT        dbo.Detalle_Venta.ID_detalle_venta, dbo.Detalle_Venta.ID_Venta, dbo.Detalle_Venta.ID_Producto, dbo.Producto.Nombre_Producto, dbo.Detalle_Venta.Cantidad, dbo.Detalle_Venta.Precio_unitario
FROM            dbo.Detalle_Venta INNER JOIN
                         dbo.Producto ON dbo.Detalle_Venta.ID_Producto = dbo.Producto.ID_Producto


GO
SET IDENTITY_INSERT [dbo].[Backups] ON 

GO
INSERT [dbo].[Backups] ([ID_BackUp], [Descripcion_backup]) VALUES (1, N'Backup: rock Fecha: 21-11-2018 16.57.03')
GO
INSERT [dbo].[Backups] ([ID_BackUp], [Descripcion_backup]) VALUES (2, N'Backup: gonogo Fecha: 21-11-2018 17.03.09')
GO
INSERT [dbo].[Backups] ([ID_BackUp], [Descripcion_backup]) VALUES (3, N'Backup: C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\Backup\pruebanow.BAK Fecha: 21/11/2018 17:17:35')
GO
INSERT [dbo].[Backups] ([ID_BackUp], [Descripcion_backup]) VALUES (4, N'Backup:  Fecha: 21/11/2018 17:18:02')
GO
INSERT [dbo].[Backups] ([ID_BackUp], [Descripcion_backup]) VALUES (5, N'Backup:  Fecha: 21/11/2018 17:20:33')
GO
SET IDENTITY_INSERT [dbo].[Backups] OFF
GO
SET IDENTITY_INSERT [dbo].[Bitacora] ON 

GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (1, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-17 00:00:00.000' AS DateTime), N'3', 3441)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (2, 2, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-17 00:00:00.000' AS DateTime), N'3', 3443)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (3, 3, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-17 00:00:00.000' AS DateTime), N'3', 3445)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (4, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-17 00:00:00.000' AS DateTime), N'3', 3444)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (5, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-17 21:23:39.000' AS DateTime), N'3', 3901)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (6, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-17 21:28:41.000' AS DateTime), N'3', 3900)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (7, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-17 21:30:08.000' AS DateTime), N'3', 3897)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (8, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-19 18:37:44.000' AS DateTime), N'3', 3913)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (9, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-19 20:00:22.000' AS DateTime), N'3', 3893)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (10, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-19 20:03:31.000' AS DateTime), N'3', 3936)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (11, 1, N'AGREGAR USUARIO', N'USUARIO:Alta,Código: 4', CAST(N'2018-11-19 20:04:03.000' AS DateTime), N'2', 4143)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (12, 1, N'ACTUALIZACION DE BITACORA', N'USU_FAM:Cambio Código: 4', CAST(N'2018-11-19 20:04:33.000' AS DateTime), N'2', 5004)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (13, 1, N'ACTUALIZACION DE BITACORA', N'USU_PAT:Cambio Código: 4', CAST(N'2018-11-19 20:04:38.000' AS DateTime), N'2', 5027)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (14, 1, N'ACTUALIZACION DE BITACORA', N'USU_FAM:Cambio Código: 2', CAST(N'2018-11-19 20:06:49.000' AS DateTime), N'2', 5013)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (15, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-19 20:08:03.000' AS DateTime), N'3', 3945)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (16, 1, N'ACTUALIZACION DE BITACORA', N'USU_FAM:Cambio Código: 2', CAST(N'2018-11-19 20:09:33.000' AS DateTime), N'2', 5011)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (17, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-19 20:13:42.000' AS DateTime), N'3', 3946)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (18, 1, N'ACTUALIZACION DE BITACORA', N'USU_FAM:Cambio Código: 2', CAST(N'2018-11-19 20:14:25.000' AS DateTime), N'2', 5010)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (19, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-19 20:19:05.000' AS DateTime), N'3', 3953)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (20, 1, N'ACTUALIZACION DE BITACORA', N'USU_FAM:Cambio Código: 2', CAST(N'2018-11-19 20:19:36.000' AS DateTime), N'2', 5010)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (21, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-19 20:26:55.000' AS DateTime), N'3', 3949)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (22, 1, N'USUARIO FAMILIA PATENTE', N'USU_FAM:Cambio Código: 1', CAST(N'2018-11-19 20:27:34.000' AS DateTime), N'2', 4903)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (23, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-19 20:41:03.000' AS DateTime), N'3', 3941)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (24, 1, N'USUARIO FAMILIA PATENTE', N'USU_PAT:Cambio Código: 2', CAST(N'2018-11-19 20:41:27.000' AS DateTime), N'2', 4921)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (25, 1, N'USUARIO FAMILIA PATENTE', N'USU_FAM:Cambio Código: 3', CAST(N'2018-11-19 20:42:00.000' AS DateTime), N'2', 4898)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (26, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-19 20:42:51.000' AS DateTime), N'3', 3948)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (27, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-19 20:43:22.000' AS DateTime), N'3', 3948)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (28, 1, N'ACTUALIZA FAMILIA PATENTE', N'FAMILIA_PATENTE:Cambio Código: 6', CAST(N'2018-11-19 20:44:13.000' AS DateTime), N'2', 5591)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (29, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-19 20:44:47.000' AS DateTime), N'3', 3958)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (30, 1, N'ALTA FAMILIA', N'FAMILIA:Alta Código: 6', CAST(N'2018-11-19 20:48:39.000' AS DateTime), N'2', 3830)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (31, 1, N'ACTUALIZA FAMILIA PATENTE', N'FAMILIA_PATENTE:Cambio Código: 7', CAST(N'2018-11-19 20:48:56.000' AS DateTime), N'2', 5597)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (32, 1, N'ACTUALIZA FAMILIA PATENTE', N'FAMILIA_PATENTE:Cambio Código: 6', CAST(N'2018-11-19 20:49:53.000' AS DateTime), N'2', 5595)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (33, 1, N'ACTUALIZA FAMILIA PATENTE', N'FAMILIA_PATENTE:Cambio Código: 6', CAST(N'2018-11-19 20:51:14.000' AS DateTime), N'2', 5586)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (34, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-19 20:57:01.000' AS DateTime), N'3', 3948)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (35, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-19 20:58:55.000' AS DateTime), N'3', 3959)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (36, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 1', CAST(N'2018-11-19 20:59:16.000' AS DateTime), N'2', 5259)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (37, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 2', CAST(N'2018-11-19 20:59:27.000' AS DateTime), N'2', 5263)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (38, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 3', CAST(N'2018-11-19 20:59:32.000' AS DateTime), N'2', 5261)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (39, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 8', CAST(N'2018-11-19 21:00:13.000' AS DateTime), N'2', 5253)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (40, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 7', CAST(N'2018-11-19 21:00:21.000' AS DateTime), N'2', 5243)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (41, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 9', CAST(N'2018-11-19 21:00:32.000' AS DateTime), N'2', 5248)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (42, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 11', CAST(N'2018-11-19 21:01:11.000' AS DateTime), N'2', 5288)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (43, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 12', CAST(N'2018-11-19 21:01:35.000' AS DateTime), N'2', 5296)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (44, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 14', CAST(N'2018-11-19 21:01:49.000' AS DateTime), N'2', 5304)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (45, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 15', CAST(N'2018-11-19 21:02:05.000' AS DateTime), N'2', 5299)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (46, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 15', CAST(N'2018-11-19 21:02:23.000' AS DateTime), N'2', 5300)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (47, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 18', CAST(N'2018-11-19 21:02:54.000' AS DateTime), N'2', 5308)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (48, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 19', CAST(N'2018-11-19 21:03:00.000' AS DateTime), N'2', 5302)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (49, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 20', CAST(N'2018-11-19 21:03:05.000' AS DateTime), N'2', 5300)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (50, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 21', CAST(N'2018-11-19 21:03:12.000' AS DateTime), N'2', 5291)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (51, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 22', CAST(N'2018-11-19 21:03:18.000' AS DateTime), N'2', 5299)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (52, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 24', CAST(N'2018-11-19 21:03:38.000' AS DateTime), N'2', 5304)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (53, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 27', CAST(N'2018-11-19 21:04:01.000' AS DateTime), N'2', 5299)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (54, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 29', CAST(N'2018-11-19 21:07:32.000' AS DateTime), N'2', 5309)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (55, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 30', CAST(N'2018-11-19 21:07:38.000' AS DateTime), N'2', 5308)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (56, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 31', CAST(N'2018-11-19 21:07:47.000' AS DateTime), N'2', 5310)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (57, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 32', CAST(N'2018-11-19 21:07:52.000' AS DateTime), N'2', 5308)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (58, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 33', CAST(N'2018-11-19 21:07:57.000' AS DateTime), N'2', 5315)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (59, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 34', CAST(N'2018-11-19 21:08:01.000' AS DateTime), N'2', 5307)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (60, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 34', CAST(N'2018-11-19 21:08:05.000' AS DateTime), N'2', 5303)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (61, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 35', CAST(N'2018-11-19 21:08:09.000' AS DateTime), N'2', 5309)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (62, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 38', CAST(N'2018-11-19 21:08:28.000' AS DateTime), N'2', 5314)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (63, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 39', CAST(N'2018-11-19 21:08:48.000' AS DateTime), N'2', 5318)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (64, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 40', CAST(N'2018-11-19 21:08:52.000' AS DateTime), N'2', 5306)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (65, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 41', CAST(N'2018-11-19 21:08:55.000' AS DateTime), N'2', 5311)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (66, 1, N'ACTUALIZAR PATENTE', N'PATENTE:Modificación Código 42', CAST(N'2018-11-19 21:09:02.000' AS DateTime), N'2', 5306)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (67, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-19 21:17:59.000' AS DateTime), N'3', 3964)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (68, 1, N'ACTUALIZAR FAMILIA', N'FAMILIA:Modific. Código: 1', CAST(N'2018-11-19 21:20:27.000' AS DateTime), N'3', 4646)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (69, 1, N'ACTUALIZA FAMILIA PATENTE', N'FAMILIA_PATENTE:Cambio Código: 2', CAST(N'2018-11-19 21:23:35.000' AS DateTime), N'2', 5594)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (70, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-19 21:31:51.000' AS DateTime), N'3', 3946)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (71, 1, N'ACTUALIZA FAMILIA PATENTE', N'FAMILIA_PATENTE:Cambio Código: 6', CAST(N'2018-11-19 21:33:06.000' AS DateTime), N'2', 5590)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (72, 1, N'ACTUALIZA FAMILIA PATENTE', N'FAMILIA_PATENTE:Cambio Código: 6', CAST(N'2018-11-19 21:35:59.000' AS DateTime), N'2', 5601)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (73, 1, N'ACTUALIZA FAMILIA PATENTE', N'FAMILIA_PATENTE:Cambio Código: 6', CAST(N'2018-11-19 21:47:22.000' AS DateTime), N'2', 5595)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (74, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2474)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (75, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:16:34.000' AS DateTime), N'3', 4257)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (76, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2476)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (77, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:17:23.000' AS DateTime), N'3', 4258)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (78, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2478)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (79, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:18:45.000' AS DateTime), N'3', 4265)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (80, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2471)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (81, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:19:24.000' AS DateTime), N'3', 4256)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (82, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2473)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (83, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:19:50.000' AS DateTime), N'3', 4257)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (84, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2475)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (85, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:20:34.000' AS DateTime), N'3', 4253)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (86, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2477)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (87, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:21:32.000' AS DateTime), N'3', 4254)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (88, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2479)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (89, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:21:59.000' AS DateTime), N'3', 4265)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (90, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2472)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (91, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:22:50.000' AS DateTime), N'3', 4250)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (92, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2474)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (93, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:23:37.000' AS DateTime), N'3', 4258)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (94, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente_Familia ', CAST(N'2018-11-21 09:23:40.000' AS DateTime), N'1', 5957)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (95, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2477)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (96, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:24:10.000' AS DateTime), N'3', 4253)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (97, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente_Familia ', CAST(N'2018-11-21 09:24:11.000' AS DateTime), N'1', 5959)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (98, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2480)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (99, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:24:52.000' AS DateTime), N'3', 4262)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (100, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente_Familia ', CAST(N'2018-11-21 09:24:54.000' AS DateTime), N'1', 5999)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (101, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2513)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (102, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:26:08.000' AS DateTime), N'3', 4298)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (103, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente_Familia ', CAST(N'2018-11-21 09:26:09.000' AS DateTime), N'1', 6004)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (104, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2516)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (105, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:27:29.000' AS DateTime), N'3', 4305)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (106, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente_Familia ', CAST(N'2018-11-21 09:27:30.000' AS DateTime), N'1', 6002)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (107, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2519)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (108, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:28:15.000' AS DateTime), N'3', 4304)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (109, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente_Familia ', CAST(N'2018-11-21 09:28:16.000' AS DateTime), N'1', 6010)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (110, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2513)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (111, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:29:10.000' AS DateTime), N'3', 4294)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (112, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Usuario ', CAST(N'2018-11-21 09:29:11.000' AS DateTime), N'1', 5237)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (113, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2516)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (114, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:30:37.000' AS DateTime), N'3', 4298)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (115, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Usuario ', CAST(N'2018-11-21 09:30:38.000' AS DateTime), N'1', 5241)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (116, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente ', CAST(N'2018-11-21 09:30:40.000' AS DateTime), N'1', 5212)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (117, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2520)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (118, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:32:54.000' AS DateTime), N'3', 4303)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (119, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Usuario ', CAST(N'2018-11-21 09:32:55.000' AS DateTime), N'1', 5246)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (120, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente ', CAST(N'2018-11-21 09:33:00.000' AS DateTime), N'1', 5206)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (121, 1, N'CIERRE SESION USUARIO', N'USUARIO: Cierre Sesion Código:1', CAST(N'2018-11-21 09:33:25.000' AS DateTime), N'3', 5444)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (122, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2516)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (123, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:34:24.000' AS DateTime), N'3', 4298)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (124, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Usuario ', CAST(N'2018-11-21 09:34:25.000' AS DateTime), N'1', 5241)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (125, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente ', CAST(N'2018-11-21 09:34:32.000' AS DateTime), N'1', 5217)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (126, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2520)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (127, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:37:32.000' AS DateTime), N'3', 4304)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (128, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Usuario ', CAST(N'2018-11-21 09:37:38.000' AS DateTime), N'1', 5252)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (129, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente ', CAST(N'2018-11-21 09:37:42.000' AS DateTime), N'1', 5225)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (130, 1, N'CIERRE SESION USUARIO', N'USUARIO: Cierre Sesion Código:1', CAST(N'2018-11-21 09:38:10.000' AS DateTime), N'3', 5443)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (131, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2516)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (132, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:40:47.000' AS DateTime), N'3', 4300)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (133, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Usuario ', CAST(N'2018-11-21 09:40:48.000' AS DateTime), N'1', 5243)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (134, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente ', CAST(N'2018-11-21 09:40:49.000' AS DateTime), N'1', 5222)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (135, 1, N'CIERRE SESION USUARIO', N'USUARIO: Cierre Sesion Código:1', CAST(N'2018-11-21 09:41:09.000' AS DateTime), N'3', 5450)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (136, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2521)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (137, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:44:53.000' AS DateTime), N'3', 4306)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (138, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Usuario ', CAST(N'2018-11-21 09:44:54.000' AS DateTime), N'1', 5249)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (139, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente ', CAST(N'2018-11-21 09:44:56.000' AS DateTime), N'1', 5229)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (140, 1, N'CIERRE SESION USUARIO', N'USUARIO: Cierre Sesion Código:1', CAST(N'2018-11-21 09:45:29.000' AS DateTime), N'3', 5452)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (141, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2517)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (142, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:45:42.000' AS DateTime), N'3', 4301)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (143, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Usuario ', CAST(N'2018-11-21 09:45:43.000' AS DateTime), N'1', 5244)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (144, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente ', CAST(N'2018-11-21 09:45:43.000' AS DateTime), N'1', 5222)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (145, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2521)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (146, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:49:43.000' AS DateTime), N'3', 4310)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (147, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Usuario ', CAST(N'2018-11-21 09:49:44.000' AS DateTime), N'1', 5253)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (148, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente ', CAST(N'2018-11-21 09:49:45.000' AS DateTime), N'1', 5232)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (149, 1, N'CIERRE SESION USUARIO', N'USUARIO: Cierre Sesion Código:1', CAST(N'2018-11-21 09:50:09.000' AS DateTime), N'3', 5455)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (150, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2517)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (151, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:52:03.000' AS DateTime), N'3', 4296)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (152, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Usuario ', CAST(N'2018-11-21 09:52:04.000' AS DateTime), N'1', 5239)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (153, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente ', CAST(N'2018-11-21 09:52:05.000' AS DateTime), N'1', 5218)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (154, 1, N'CIERRE SESION USUARIO', N'USUARIO: Cierre Sesion Código:1', CAST(N'2018-11-21 09:52:21.000' AS DateTime), N'3', 5447)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (155, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2522)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (156, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:52:42.000' AS DateTime), N'3', 4304)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (157, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Usuario ', CAST(N'2018-11-21 09:52:43.000' AS DateTime), N'1', 5247)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (158, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente ', CAST(N'2018-11-21 09:52:44.000' AS DateTime), N'1', 5226)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (159, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2526)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (160, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:54:02.000' AS DateTime), N'3', 4297)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (161, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Usuario ', CAST(N'2018-11-21 09:54:02.000' AS DateTime), N'1', 5239)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (162, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente ', CAST(N'2018-11-21 09:54:03.000' AS DateTime), N'1', 5218)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (163, 1, N'CIERRE SESION USUARIO', N'USUARIO: Cierre Sesion Código:1', CAST(N'2018-11-21 09:54:36.000' AS DateTime), N'3', 5455)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (164, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2522)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (165, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 09:55:21.000' AS DateTime), N'3', 4304)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (166, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Usuario ', CAST(N'2018-11-21 09:55:22.000' AS DateTime), N'1', 5247)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (167, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente ', CAST(N'2018-11-21 09:55:23.000' AS DateTime), N'1', 5226)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (168, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2526)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (169, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 10:05:06.000' AS DateTime), N'3', 4346)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (170, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Usuario ', CAST(N'2018-11-21 10:05:07.000' AS DateTime), N'1', 5280)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (171, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente ', CAST(N'2018-11-21 10:05:07.000' AS DateTime), N'1', 5258)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (172, 1, N'CIERRE SESION USUARIO', N'USUARIO: Cierre Sesion Código:1', CAST(N'2018-11-21 10:05:10.000' AS DateTime), N'3', 5483)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (173, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2522)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (174, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 12:59:05.000' AS DateTime), N'3', 4352)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (175, 1, N'Error D.V.', N'Error D.V. Item: 173 Tabla/Table: Bitacora ', CAST(N'2018-11-21 12:59:08.000' AS DateTime), N'1', 5464)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (176, 1, N'CIERRE SESION USUARIO', N'USUARIO: Cierre Sesion Código:1', CAST(N'2018-11-21 13:00:06.000' AS DateTime), N'3', 5490)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (177, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2526)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (178, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 13:02:09.000' AS DateTime), N'3', 4349)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (179, 1, N'CIERRE SESION USUARIO', N'USUARIO: Cierre Sesion Código:1', CAST(N'2018-11-21 13:02:50.000' AS DateTime), N'3', 5494)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (180, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2520)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (181, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 13:03:14.000' AS DateTime), N'3', 4340)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (182, 1, N'CIERRE SESION USUARIO', N'USUARIO: Cierre Sesion Código:1', CAST(N'2018-11-21 13:04:13.000' AS DateTime), N'3', 5489)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (183, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2523)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (184, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 14:30:26.000' AS DateTime), N'3', 4347)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (185, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Usuario ', CAST(N'2018-11-21 14:30:29.000' AS DateTime), N'1', 5292)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (186, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente ', CAST(N'2018-11-21 14:30:31.000' AS DateTime), N'1', 5263)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (187, 1, N'CIERRE SESION USUARIO', N'USUARIO: Cierre Sesion Código:1', CAST(N'2018-11-21 14:32:28.000' AS DateTime), N'3', 5502)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (188, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2528)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (189, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 14:34:44.000' AS DateTime), N'3', 4356)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (190, 1, N'Error Alta Usuario', N'Error Alta Usuario5', CAST(N'2018-11-21 14:36:28.000' AS DateTime), N'1', 4691)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (191, 1, N'Error Alta Usuario', N'Error Alta Usuario6', CAST(N'2018-11-21 14:40:09.000' AS DateTime), N'1', 4687)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (192, 1, N'Error Alta Usuario', N'Error Alta Usuario7', CAST(N'2018-11-21 14:41:21.000' AS DateTime), N'1', 4684)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (193, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2524)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (194, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 14:51:09.000' AS DateTime), N'3', 4352)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (195, 1, N'Error D.V.', N'Error D.V. Item: 5 Tabla/Table: Usuario ', CAST(N'2018-11-21 14:51:12.000' AS DateTime), N'1', 5292)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (196, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente ', CAST(N'2018-11-21 14:51:13.000' AS DateTime), N'1', 5267)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (197, 1, N'Error Modificacion Usuario', N'Error Modificación Usuario2', CAST(N'2018-11-21 14:52:34.000' AS DateTime), N'1', 6492)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (198, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2529)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (199, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 14:54:16.000' AS DateTime), N'3', 4358)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (200, 1, N'Error D.V.', N'Error D.V. Item: 173 Tabla/Table: Bitacora ', CAST(N'2018-11-21 14:54:17.000' AS DateTime), N'1', 5450)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (201, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2514)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (202, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 14:54:57.000' AS DateTime), N'3', 4348)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (203, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2516)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (204, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 14:56:57.000' AS DateTime), N'3', 4352)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (205, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2518)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (206, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 14:58:17.000' AS DateTime), N'3', 4352)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (207, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2520)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (208, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 15:01:42.000' AS DateTime), N'3', 4341)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (209, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2522)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (210, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 15:03:32.000' AS DateTime), N'3', 4335)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (211, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2515)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (212, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 15:08:21.000' AS DateTime), N'3', 4340)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (213, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2517)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (214, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 15:09:44.000' AS DateTime), N'3', 4348)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (215, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2519)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (216, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 15:12:29.000' AS DateTime), N'3', 4347)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (217, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2521)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (218, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 15:13:04.000' AS DateTime), N'3', 4343)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (219, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2523)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (220, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 15:13:25.000' AS DateTime), N'3', 4339)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (221, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2516)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (222, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 15:22:00.000' AS DateTime), N'3', 4334)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (223, 1, N'CIERRE SESION USUARIO', N'USUARIO: Cierre Sesion Código:1', CAST(N'2018-11-21 15:22:26.000' AS DateTime), N'3', 5491)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (224, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2519)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (225, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 15:30:04.000' AS DateTime), N'3', 4340)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (226, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 2521)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (227, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 15:43:21.000' AS DateTime), N'3', 4345)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (228, 1, N'Error D.V.', N'Error D.V. Item: 3 Tabla/Table: Patente_Familia ', CAST(N'2018-11-21 15:43:23.000' AS DateTime), N'1', 6054)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (229, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente ', CAST(N'2018-11-21 15:43:25.000' AS DateTime), N'1', 5269)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (230, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (231, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 15:45:47.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (232, 1, N'Error D.V.', N'Error D.V. Item: 230 Tabla/Table: Bitacora ', CAST(N'2018-11-21 15:45:49.000' AS DateTime), N'1', 5455)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (233, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (234, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 15:52:16.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (235, 1, N'Error D.V.', N'Error D.V. Item: 230 Tabla/Table: Bitacora ', CAST(N'2018-11-21 15:52:17.000' AS DateTime), N'1', 5451)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (236, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (237, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 15:54:57.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (238, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (239, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 16:08:01.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (240, 1, N'Error D.V.', N'Error D.V. Item: 3 Tabla/Table: Patente_Familia ', CAST(N'2018-11-21 16:08:02.000' AS DateTime), N'1', 6047)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (241, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente ', CAST(N'2018-11-21 16:08:03.000' AS DateTime), N'1', 5261)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (242, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (243, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 16:15:49.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (244, 1, N'Error D.V.', N'Error D.V. Item: 3 Tabla/Table: Patente_Familia ', CAST(N'2018-11-21 16:16:08.000' AS DateTime), N'1', 6056)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (245, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente ', CAST(N'2018-11-21 16:16:13.000' AS DateTime), N'1', 5265)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (246, 1, N'H+S4kVrlj8LiQhgkLj75sQ==', N'2POic2BO+O2EPkk/LEMHdxZK0R1F7CdJ', CAST(N'2018-11-21 16:18:56.000' AS DateTime), N'C3gIf0CZLKc=', 6499)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (247, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (248, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 16:22:15.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (249, 1, N'Error D.V.', N'Error D.V. Item: 3 Tabla/Table: Patente_Familia ', CAST(N'2018-11-21 16:22:16.000' AS DateTime), N'1', 6057)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (250, 1, N'Error D.V.', N'Error D.V. Item: 1 Tabla/Table: Patente ', CAST(N'2018-11-21 16:22:17.000' AS DateTime), N'1', 5262)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (251, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (252, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 16:24:43.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (253, 1, N'Error D.V.', N'Error D.V. Item: 230 Tabla/Table: Bitacora ', CAST(N'2018-11-21 16:24:44.000' AS DateTime), N'1', 5451)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (254, 1, N'Error Modificación Usuario', N'Error Modificación Usuario: 5', CAST(N'2018-11-21 16:26:30.000' AS DateTime), N'1', 6710)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (255, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (256, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 16:32:21.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (257, 1, N'CIERRE SESION USUARIO', N'USUARIO: Cierre Sesion Código:1', CAST(N'2018-11-21 16:32:43.000' AS DateTime), N'3', 5499)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (258, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (259, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 16:33:52.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (260, 1, N'MODIFICACION DE USUARIO', N'USUARIO:Modificación Código: 4', CAST(N'2018-11-21 16:34:26.000' AS DateTime), N'2', 5691)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (261, 1, N'BAJA DE USUARIO', N'USUARIO:Baja Código: 6', CAST(N'2018-11-21 16:35:00.000' AS DateTime), N'2', 4101)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (262, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (263, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 16:45:17.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (264, 1, N'Error D.V.', N'Error D.V. Item: 230 Tabla/Table: Bitacora ', CAST(N'2018-11-21 16:45:18.000' AS DateTime), N'1', 5457)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (265, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (266, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 16:47:16.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (267, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (268, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 16:50:10.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (269, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (270, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 16:51:30.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (271, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (272, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 16:53:39.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (273, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (274, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 16:56:44.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (275, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (276, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 16:59:49.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (277, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (278, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 17:01:26.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (279, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (280, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 17:02:53.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (281, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (282, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 17:06:37.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (283, 1, N'Error D.V.', N'Error D.V. Item: 230 Tabla/Table: Bitacora ', CAST(N'2018-11-21 17:06:41.000' AS DateTime), N'1', 5452)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (284, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (285, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 17:09:41.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (286, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (287, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 17:17:17.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (288, 1, N'CIERRE SESION USUARIO', N'USUARIO: Cierre Sesion Código:1', CAST(N'2018-11-21 17:18:08.000' AS DateTime), N'3', 5509)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (289, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (290, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 17:18:51.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (291, 1, N'ALTA PATENTE', N'PATENTE: Alta Código: 43', CAST(N'2018-11-21 17:19:40.000' AS DateTime), N'2', 4017)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (292, 1, N'ELIMINA PATENTE', N'PATENTE:Eliminación Código: 43', CAST(N'2018-11-21 17:19:56.000' AS DateTime), N'2', 5088)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (293, 1, N'CIERRE SESION USUARIO', N'USUARIO: Cierre Sesion Código:1', CAST(N'2018-11-21 17:35:39.000' AS DateTime), N'3', 5508)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (294, 1, N'LOGIN', N'LOGIN SATISFACTORIO', CAST(N'2018-11-21 00:00:00.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (295, 1, N'LOGIN USER', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-21 17:49:24.000' AS DateTime), N'3', 0)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (296, 1, N'Error D.V.', N'Error D.V. Item: 4 Tabla/Table: Patente ', CAST(N'2018-11-21 17:49:25.000' AS DateTime), N'1', 5284)
GO
SET IDENTITY_INSERT [dbo].[Bitacora] OFF
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 

GO
INSERT [dbo].[Categoria] ([ID_Categoria], [Nombre_Categoria]) VALUES (1, N'Cerradura')
GO
INSERT [dbo].[Categoria] ([ID_Categoria], [Nombre_Categoria]) VALUES (2, N'Llaves')
GO
INSERT [dbo].[Categoria] ([ID_Categoria], [Nombre_Categoria]) VALUES (3, N'Candados')
GO
SET IDENTITY_INSERT [dbo].[Categoria] OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

GO
INSERT [dbo].[Cliente] ([ID_Cliente], [Nombre], [Apellido], [DNI], [Mail], [DVH]) VALUES (2, N'Matias', N'Otarola', N'40080243', N'matias.e.otarola@gmail.com', NULL)
GO
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
INSERT [dbo].[DVV] ([Nombre_Tabla], [DVV]) VALUES (N'Bitacora', 1101666)
GO
INSERT [dbo].[DVV] ([Nombre_Tabla], [DVV]) VALUES (N'Usuario', 42869)
GO
INSERT [dbo].[DVV] ([Nombre_Tabla], [DVV]) VALUES (N'Patente_Familia', 12722)
GO
INSERT [dbo].[DVV] ([Nombre_Tabla], [DVV]) VALUES (N'Usuario_Patente', 0)
GO
INSERT [dbo].[DVV] ([Nombre_Tabla], [DVV]) VALUES (N'Patente', 80817)
GO
INSERT [dbo].[Familia] ([ID_Familia], [Nombre_familia], [Descripcion_familia]) VALUES (1, N'Administrador', N'Usuario con máximos permisos')
GO
INSERT [dbo].[Familia] ([ID_Familia], [Nombre_familia], [Descripcion_familia]) VALUES (2, N'Ventas', N'Administrador de ventas')
GO
INSERT [dbo].[Familia] ([ID_Familia], [Nombre_familia], [Descripcion_familia]) VALUES (3, N'Producto', N'Administrador de productos y categorías')
GO
INSERT [dbo].[Familia] ([ID_Familia], [Nombre_familia], [Descripcion_familia]) VALUES (4, N'Bajas', N'Administrador de bajas')
GO
INSERT [dbo].[Familia] ([ID_Familia], [Nombre_familia], [Descripcion_familia]) VALUES (5, N'Seguridad', N'Administrador de Seguridad de Aplicacion')
GO
INSERT [dbo].[Familia] ([ID_Familia], [Nombre_familia], [Descripcion_familia]) VALUES (6, N'PruebaAlta', N'Prueba nueva fam')
GO
INSERT [dbo].[Familia_Usuario] ([ID_Usuario], [ID_Familia], [Descripcion_familia_usuario]) VALUES (1, 1, N'Administrador General')
GO
INSERT [dbo].[Familia_Usuario] ([ID_Usuario], [ID_Familia], [Descripcion_familia_usuario]) VALUES (2, 1, N'Administrador General')
GO
INSERT [dbo].[Familia_Usuario] ([ID_Usuario], [ID_Familia], [Descripcion_familia_usuario]) VALUES (3, 2, N'Ventas')
GO
INSERT [dbo].[Familia_Usuario] ([ID_Usuario], [ID_Familia], [Descripcion_familia_usuario]) VALUES (4, 5, N'Seguridad')
GO
INSERT [dbo].[Familia_Usuario] ([ID_Usuario], [ID_Familia], [Descripcion_familia_usuario]) VALUES (5, 2, N'Ventas')
GO
INSERT [dbo].[Familia_Usuario] ([ID_Usuario], [ID_Familia], [Descripcion_familia_usuario]) VALUES (9, 3, N'Producto')
GO
INSERT [dbo].[Idioma] ([ID_Idioma], [Nombre_idioma]) VALUES (1, N'Español')
GO
INSERT [dbo].[Idioma] ([ID_Idioma], [Nombre_idioma]) VALUES (2, N'Inglés')
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (1, N'Alta usuario', N'Ninguna', 1963)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (2, N'Modificar usuario', N'Alta usuario', 2962)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (3, N'Baja usuario', N'Baja usuario', 2399)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (4, N'Asignar usuario familia', N'Alta usuario', 3521)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (5, N'Asignar patente usuario', N'Alta usuario', 3552)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (6, N'Asignar patente familia', N'Alta usuario', 3500)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (7, N'Quitar patente usuario', N'Asignar patente usuario', 4623)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (8, N'Quitar patente familia', N'Asignar patente familia', 4518)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (9, N'Quitar usuario familia', N'Asignar usuario familia', 4566)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (10, N'Alta cliente', N'Alta usuario', 2454)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (11, N'Modificar cliente', N'Alta cliente', 2945)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (12, N'baja cliente', N'Alta cliente', 2434)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (13, N'Alta venta', N'Ninguno', 1792)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (14, N'Modificar venta', N'Alta venta', 2543)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (15, N'Baja venta', N'Alta venta', 2000)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (16, N'Alta reserva', N'Alta venta', 2240)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (17, N'Modificar reserva', N'Alta reserva', 2985)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (18, N'Baja reserva', N'Alta reserva', 2443)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (19, N'Alta producto', N'Ninguno', 2131)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (20, N'Modificar producto', N'Modificar producto', 3744)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (21, N'Baja producto', N'Alta producto', 2677)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (22, N'Alta categoria', N'Alta producto', 2761)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (23, N'Modificar categoria', N'Alta categoria', 3349)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (24, N'Baja categoria', N'Alta categoria', 2806)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (25, N'Backup', N'Alta usuario', 1899)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (26, N'Restore', N'Backup', 1446)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (27, N'Bitacora', N'Alta usuario', 2099)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (28, N'DV', N'Alta usuario', 1449)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (29, N'Habilitar usuario', N'Alta usuario', 3016)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (1, 1, 1, 514)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (2, 1, 1, 515)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (3, 1, 1, 516)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (4, 4, 1, 516)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (5, 1, 1, 520)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (6, 1, 1, 521)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (7, 1, 1, 522)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (8, 1, 1, 563)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (9, 1, 1, 564)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (10, 1, 1, 566)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (11, 2, 1, 568)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (12, 2, 1, 571)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (13, 2, 1, 572)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (14, 4, 1, 572)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (15, 2, 1, 564)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (16, 2, 1, 565)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (17, 2, 1, 566)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (18, 4, 1, 566)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (19, 2, 1, 568)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (20, 2, 1, 571)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (21, 2, 1, 573)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (22, 4, 1, 573)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (23, 5, 1, 576)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (24, 5, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (25, 5, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (26, 5, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (27, 5, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (28, 5, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (29, 5, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

GO
INSERT [dbo].[Producto] ([ID_Producto], [ID_Categoria], [ID_Reserva], [Descripcion], [Nombre_Producto], [Stock], [Precio_Compra], [Precio_Venta], [imagen], [DVH]) VALUES (1, 1, NULL, N'wstr', N'labe', CAST(12.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 0xFFD8FFE000104A46494600010101000000000000FFDB0043000906070808080707080707070707070A07070707070F0809070A2011162215111313182828201826251B131321312125292B2E2E2E171F3338332C37282D2E2BFFDB0043010A0A0A0D0D0D0E100D0E2B1915192B2B2B2B2B2B2B2B2B2B372B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2BFFC000110800B2011B03012200021101031101FFC400190001010003010000000000000000000000000102040507FFC400161001010100000000000000000000000000000111FFC4001501010100000000000000000000000000000001FFC40014110100000000000000000000000000000000FFDA000C03010002110311003F00F66450100011500001116A202140428802000820000008054540000400111404454044655018A3201D201411500454011510404010400A200800200008000022A000020A8022A020501115010501D101441528214440454010A80208022A00800020000000095528000200082A0200085004001D10450454404004454044540104001000004000000001140400100011500454044501000745152A8808020880854010A80020000080000000000000080008A8022A015150105404001D0454504A540104010440A8200140115000504140415000000004001140400111404450111406F022888A94111510445401000001014000004001014401440000045400400150105404001BA944504A220208022A000000000000008A80800000000000200082A02C4540400045406E31540445A802080000000000000000255018D15000C00050114044C50111501500128008080DBA82008008000000000000000A00228088A000020A0008022A02255400001150111501B485401000000000000000545000000040004000000134040010001000A2008A80D82A0000000000040000005800000000850040000012A280C4A0020000020008200FFFD9, NULL)
GO
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
INSERT [dbo].[Usuario] ([ID_Usuario], [Nombre_Usuario], [Contraseña_usuario], [Nick_Usuario], [Bloqueo], [DNI], [Mail], [Idioma], [DVH]) VALUES (1, N'admin', N'NtzE0a7IUPk=', N'Administrador', 0, 11111111, N'admin@yopmail.com', 1, 5567)
GO
INSERT [dbo].[Usuario] ([ID_Usuario], [Nombre_Usuario], [Contraseña_usuario], [Nick_Usuario], [Bloqueo], [DNI], [Mail], [Idioma], [DVH]) VALUES (2, N'Ivana Yael Currá', N'NtzE0a7IUPk=', N'IvanaYC', 0, 34123042, N'ivanayael@hotmail.co', 1, 6250)
GO
INSERT [dbo].[Usuario] ([ID_Usuario], [Nombre_Usuario], [Contraseña_usuario], [Nick_Usuario], [Bloqueo], [DNI], [Mail], [Idioma], [DVH]) VALUES (3, N'Juancarlos', N'NtzE0a7IUPk=', N'Juanito', 0, 34129034, N'juanito@yopmail.com', 1, 5718)
GO
INSERT [dbo].[Usuario] ([ID_Usuario], [Nombre_Usuario], [Contraseña_usuario], [Nick_Usuario], [Bloqueo], [DNI], [Mail], [Idioma], [DVH]) VALUES (4, N'juan', N'NtzE0a7IUPk=', N'juanenrique', 0, 34949411, N'enriquep@yopmail.com', 2, 5689)
GO
INSERT [dbo].[Usuario] ([ID_Usuario], [Nombre_Usuario], [Contraseña_usuario], [Nick_Usuario], [Bloqueo], [DNI], [Mail], [Idioma], [DVH]) VALUES (5, N'prueba', N'RVRBC5LKLZc=', N'prueba', 0, 34123042, N'prueba@yopmail.com', 1, 5018)
GO
INSERT [dbo].[Usuario] ([ID_Usuario], [Nombre_Usuario], [Contraseña_usuario], [Nick_Usuario], [Bloqueo], [DNI], [Mail], [Idioma], [DVH]) VALUES (7, N'prueba3', N'kL4G0gQm/5Y=', N'prueba3', 0, 34123042, N'ic@yopmail.com', 1, 4671)
GO
INSERT [dbo].[Usuario] ([ID_Usuario], [Nombre_Usuario], [Contraseña_usuario], [Nick_Usuario], [Bloqueo], [DNI], [Mail], [Idioma], [DVH]) VALUES (8, N'prueba4', N'jSjTM+Qk/Ms=', N'prueba4', 0, 34123942, N'prueba@yopmail.com', 1, 5208)
GO
INSERT [dbo].[Usuario] ([ID_Usuario], [Nombre_Usuario], [Contraseña_usuario], [Nick_Usuario], [Bloqueo], [DNI], [Mail], [Idioma], [DVH]) VALUES (9, N'prueba5', N'4rD49LJYRyY=', N'prueba5', 0, 43249083, N'iv@yopmail.com', 1, 4748)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 1, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 2, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 3, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 4, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 5, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 6, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 7, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 8, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 9, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 10, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 11, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 12, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 13, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 14, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 15, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 16, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 17, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 18, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 19, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 20, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 21, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 22, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 23, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 24, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 25, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 26, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 27, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 28, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 29, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (2, 1, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (2, 2, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (2, 3, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (5, 13, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (5, 14, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (5, 15, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (5, 16, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (5, 17, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (5, 18, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Venta] ON 

GO
INSERT [dbo].[Venta] ([ID_Venta], [ID_Cliente], [Fecha_Venta], [Tipo], [DNI], [Nro_Factura], [DVH]) VALUES (2, 2, CAST(N'2018-11-13' AS Date), N'Factura', N'40080243', 15, NULL)
GO
SET IDENTITY_INSERT [dbo].[Venta] OFF
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Usuario] FOREIGN KEY([ID_Usuario])
REFERENCES [dbo].[Usuario] ([ID_Usuario])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Usuario]
GO
ALTER TABLE [dbo].[Detalle_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Venta_Producto] FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Producto] ([ID_Producto])
GO
ALTER TABLE [dbo].[Detalle_Venta] CHECK CONSTRAINT [FK_Detalle_Venta_Producto]
GO
ALTER TABLE [dbo].[Detalle_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Venta_Venta] FOREIGN KEY([ID_Venta])
REFERENCES [dbo].[Venta] ([ID_Venta])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Detalle_Venta] CHECK CONSTRAINT [FK_Detalle_Venta_Venta]
GO
ALTER TABLE [dbo].[Familia_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Familia_Usuario_Familia] FOREIGN KEY([ID_Familia])
REFERENCES [dbo].[Familia] ([ID_Familia])
GO
ALTER TABLE [dbo].[Familia_Usuario] CHECK CONSTRAINT [FK_Familia_Usuario_Familia]
GO
ALTER TABLE [dbo].[Familia_Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Familia_Usuario_Usuario] FOREIGN KEY([ID_Usuario])
REFERENCES [dbo].[Usuario] ([ID_Usuario])
GO
ALTER TABLE [dbo].[Familia_Usuario] CHECK CONSTRAINT [FK_Familia_Usuario_Usuario]
GO
ALTER TABLE [dbo].[Mensajes]  WITH CHECK ADD  CONSTRAINT [FK_Mensajes_Idioma] FOREIGN KEY([ID_Idioma])
REFERENCES [dbo].[Idioma] ([ID_Idioma])
GO
ALTER TABLE [dbo].[Mensajes] CHECK CONSTRAINT [FK_Mensajes_Idioma]
GO
ALTER TABLE [dbo].[Patente_Familia]  WITH CHECK ADD  CONSTRAINT [FK_Patente_Familia_Familia] FOREIGN KEY([ID_Familia])
REFERENCES [dbo].[Familia] ([ID_Familia])
GO
ALTER TABLE [dbo].[Patente_Familia] CHECK CONSTRAINT [FK_Patente_Familia_Familia]
GO
ALTER TABLE [dbo].[Patente_Familia]  WITH CHECK ADD  CONSTRAINT [FK_Patente_Familia_Patente] FOREIGN KEY([ID_Patente])
REFERENCES [dbo].[Patente] ([ID_Patente])
GO
ALTER TABLE [dbo].[Patente_Familia] CHECK CONSTRAINT [FK_Patente_Familia_Patente]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Categoria] FOREIGN KEY([ID_Categoria])
REFERENCES [dbo].[Categoria] ([ID_Categoria])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Categoria]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Idioma] FOREIGN KEY([Idioma])
REFERENCES [dbo].[Idioma] ([ID_Idioma])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Idioma]
GO
ALTER TABLE [dbo].[Usuario_Patente]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Patente_Patente] FOREIGN KEY([ID_Patente])
REFERENCES [dbo].[Patente] ([ID_Patente])
GO
ALTER TABLE [dbo].[Usuario_Patente] CHECK CONSTRAINT [FK_Usuario_Patente_Patente]
GO
ALTER TABLE [dbo].[Usuario_Patente]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Patente_Usuario] FOREIGN KEY([ID_Usuario])
REFERENCES [dbo].[Usuario] ([ID_Usuario])
GO
ALTER TABLE [dbo].[Usuario_Patente] CHECK CONSTRAINT [FK_Usuario_Patente_Usuario]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Cliente] FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[Cliente] ([ID_Cliente])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Cliente]
GO
/****** Object:  StoredProcedure [dbo].[disminuir_stock]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[disminuir_stock]
@ID_Producto as integer,
@Cantidad as decimal (18,2)
as
update Producto set Stock=Stock-@Cantidad where ID_Producto=@ID_Producto



GO
/****** Object:  StoredProcedure [dbo].[editar_categoria]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_categoria]
@ID_Categoria integer,
@Nombre_Categoria varchar (50)
as
update Categoria set Nombre_Categoria=@Nombre_Categoria
where ID_Categoria=@ID_Categoria


GO
/****** Object:  StoredProcedure [dbo].[editar_cliente]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_cliente]
@ID_Cliente integer,
@Nombre varchar (250),
@Apellido varchar (250),
@Mail varchar (250),
@DNI varchar (8)
as
update cliente set Nombre=@Nombre, Apellido=@Apellido,Mail=@Mail, DNI=@DNI
where ID_Cliente=@ID_Cliente



GO
/****** Object:  StoredProcedure [dbo].[editar_detalle_venta]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_detalle_venta]
@ID_detalle_venta as integer,
@ID_Venta as integer,
@ID_Producto as integer,
@Cantidad as decimal (18,2),
@Precio_unitario as decimal (18,2)
as
update Detalle_Venta set ID_Venta=@ID_Venta,ID_Producto=@ID_Producto,Cantidad=@Cantidad,Precio_unitario=@Precio_unitario
where ID_detalle_venta=@ID_detalle_venta



GO
/****** Object:  StoredProcedure [dbo].[editar_producto]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_producto]
@ID_Producto integer,
@ID_Categoria integer,
@Nombre_Producto varchar (250),
@Descripcion varchar (250),
@Stock decimal (18,2),
@Precio_Compra decimal (18,2),
@Precio_Venta decimal (18,2),
@imagen image
as
update producto set ID_Categoria=@ID_Categoria, Nombre_Producto=@Nombre_Producto, Descripcion=@Descripcion,
Stock=@Stock, Precio_Compra=@Precio_Compra, Precio_Venta=@Precio_Venta,imagen=@imagen
where ID_Producto=@ID_Producto



GO
/****** Object:  StoredProcedure [dbo].[editar_venta]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_venta]
@ID_Venta as integer,
@ID_Cliente as integer,
@Fecha_Venta as date,
@Tipo as varchar (250),
@DNI as varchar (8),
@Nro_Factura as integer
as
update Venta set ID_Cliente=@ID_Cliente,Fecha_Venta=@Fecha_Venta,Tipo=@Tipo,DNI=@DNI, Nro_Factura=@Nro_Factura
where ID_Venta=@ID_Venta



GO
/****** Object:  StoredProcedure [dbo].[eliminar_categoria]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_categoria]
@ID_Categoria integer
as
delete from Categoria where ID_Categoria=@ID_Categoria


GO
/****** Object:  StoredProcedure [dbo].[eliminar_cliente]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_cliente]
@ID_Cliente integer
as
delete from cliente where ID_Cliente=@ID_Cliente


GO
/****** Object:  StoredProcedure [dbo].[eliminar_detalle_venta]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_detalle_venta]
@ID_detalle_venta as integer
as
delete from Detalle_Venta where ID_detalle_venta=@ID_detalle_venta



GO
/****** Object:  StoredProcedure [dbo].[eliminar_producto]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_producto]
@ID_Producto integer
as
delete from Producto where ID_Producto=@ID_Producto



GO
/****** Object:  StoredProcedure [dbo].[eliminar_venta]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_venta]
@ID_Venta as integer
as
delete from Venta where ID_Venta=@ID_Venta



GO
/****** Object:  StoredProcedure [dbo].[insertar_categoria]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_categoria]
@Nombre_Categoria varchar (50)
as
insert into categoria (Nombre_Categoria) values (@Nombre_Categoria)



GO
/****** Object:  StoredProcedure [dbo].[insertar_cliente]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_cliente]
@Nombre varchar (250),
@Apellido varchar (250),
@Mail varchar (250),
@DNI varchar (8)
as
insert into cliente (Nombre, Apellido, Mail, DNI) values (@Nombre, @Apellido, @Mail, @DNI)


GO
/****** Object:  StoredProcedure [dbo].[insertar_detalle_venta]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_detalle_venta]
@ID_Venta as integer,
@ID_Producto as integer,
@Cantidad as decimal (18,2),
@Precio_Unitario as decimal (18,2)
as
insert into detalle_venta (ID_Venta,ID_Producto,Cantidad,Precio_unitario)
values (@ID_Venta,@ID_Producto,@Cantidad,@Precio_unitario)



GO
/****** Object:  StoredProcedure [dbo].[insertar_producto]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[insertar_producto]
@ID_Categoria integer,
@Nombre_Producto varchar (250),
@Descripcion varchar (250),
@Stock decimal (18,2),
@Precio_Compra decimal (18,2),
@Precio_Venta decimal (18,2),
@imagen image
as
insert into Producto (ID_Categoria,Nombre_Producto,Descripcion,Stock,Precio_Compra,Precio_Venta,imagen)
values (@ID_Categoria,@Nombre_Producto,@Descripcion,@Stock,@Precio_Compra,@Precio_Venta,@imagen)



GO
/****** Object:  StoredProcedure [dbo].[insertar_venta]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_venta]
@ID_Cliente as integer,
@Fecha_Venta as date,
@Tipo as varchar (250),
@DNI as varchar (8),
@Nro_Factura as integer
as
insert into Venta (ID_Cliente,Fecha_Venta,Tipo,DNI, Nro_Factura)
values (@ID_Cliente,@Fecha_Venta,@Tipo,@DNI, @Nro_Factura)



GO
/****** Object:  StoredProcedure [dbo].[mostrar_categoria]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[mostrar_categoria]
as
select * from Categoria order by ID_Categoria desc



GO
/****** Object:  StoredProcedure [dbo].[mostrar_cliente]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[mostrar_cliente]
as
select * from cliente order by ID_Cliente desc


GO
/****** Object:  StoredProcedure [dbo].[mostrar_detalle_venta]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_detalle_venta]
as
SELECT        dbo.Detalle_Venta.ID_detalle_venta, dbo.Detalle_Venta.ID_Venta, dbo.Detalle_Venta.ID_Producto, dbo.Producto.Nombre_Producto, dbo.Detalle_Venta.Cantidad, dbo.Detalle_Venta.Precio_unitario
FROM            dbo.Detalle_Venta INNER JOIN
                         dbo.Producto ON dbo.Detalle_Venta.ID_Producto = dbo.Producto.ID_Producto order by dbo.Detalle_Venta.ID_detalle_venta desc

GO
/****** Object:  StoredProcedure [dbo].[mostrar_producto]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_producto]
as 
select Producto.ID_Producto, Producto.ID_Categoria, Categoria.Nombre_Categoria,Producto.Nombre_Producto,
Producto.Descripcion,Producto.Stock,Producto.Precio_Compra, Producto.Precio_Venta,
Producto.imagen
from Producto inner join Categoria on Producto.ID_Categoria=Categoria.ID_Categoria
order by Producto.ID_Producto desc


GO
/****** Object:  StoredProcedure [dbo].[mostrar_venta]    Script Date: 21/11/2018 17:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_venta]
as
SELECT        dbo.Venta.ID_Venta, dbo.Venta.ID_Cliente, dbo.Cliente.Apellido, dbo.Cliente.DNI, dbo.Venta.Fecha_Venta, dbo.Venta.Tipo, dbo.Venta.DNI AS Expr1, dbo.Venta.Nro_Factura
FROM            dbo.Venta INNER JOIN
                         dbo.Cliente ON dbo.Venta.ID_Cliente = dbo.Cliente.ID_Cliente
						 order by dbo.Venta.ID_Venta desc


GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Venta"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "Cliente"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Detalle_Venta"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 212
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Producto"
            Begin Extent = 
               Top = 6
               Left = 250
               Bottom = 136
               Right = 437
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_2'
GO
USE [master]
GO
ALTER DATABASE [SistemaVentas] SET  READ_WRITE 
GO
