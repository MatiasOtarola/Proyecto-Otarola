USE [master]
GO
/****** Object:  Database [SistemaVentas]    Script Date: 17/11/2018 21:43:10 ******/
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
/****** Object:  Table [dbo].[Backup]    Script Date: 17/11/2018 21:43:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Backup](
	[ID_BackUp] [int] NOT NULL,
	[Descripcion_backup] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Backup] PRIMARY KEY CLUSTERED 
(
	[ID_BackUp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 17/11/2018 21:43:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bitacora](
	[ID_Bitacora] [int] NOT NULL,
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
/****** Object:  Table [dbo].[Categoria]    Script Date: 17/11/2018 21:43:10 ******/
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
/****** Object:  Table [dbo].[Cliente]    Script Date: 17/11/2018 21:43:10 ******/
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
/****** Object:  Table [dbo].[Detalle_Venta]    Script Date: 17/11/2018 21:43:10 ******/
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
/****** Object:  Table [dbo].[DVV]    Script Date: 17/11/2018 21:43:10 ******/
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
/****** Object:  Table [dbo].[Error]    Script Date: 17/11/2018 21:43:10 ******/
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
/****** Object:  Table [dbo].[Familia]    Script Date: 17/11/2018 21:43:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Familia](
	[ID_Familia] [int] IDENTITY(1,1) NOT NULL,
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
/****** Object:  Table [dbo].[Familia_Usuario]    Script Date: 17/11/2018 21:43:10 ******/
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
/****** Object:  Table [dbo].[Idioma]    Script Date: 17/11/2018 21:43:10 ******/
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
/****** Object:  Table [dbo].[Mensajes]    Script Date: 17/11/2018 21:43:10 ******/
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
/****** Object:  Table [dbo].[Patente]    Script Date: 17/11/2018 21:43:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Patente](
	[ID_Patente] [int] IDENTITY(1,1) NOT NULL,
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
/****** Object:  Table [dbo].[Patente_Familia]    Script Date: 17/11/2018 21:43:10 ******/
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
/****** Object:  Table [dbo].[Producto]    Script Date: 17/11/2018 21:43:10 ******/
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
/****** Object:  Table [dbo].[Restore]    Script Date: 17/11/2018 21:43:10 ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 17/11/2018 21:43:10 ******/
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
/****** Object:  Table [dbo].[Usuario_Patente]    Script Date: 17/11/2018 21:43:10 ******/
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
/****** Object:  Table [dbo].[Venta]    Script Date: 17/11/2018 21:43:10 ******/
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
/****** Object:  View [dbo].[View_1]    Script Date: 17/11/2018 21:43:10 ******/
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
/****** Object:  View [dbo].[View_2]    Script Date: 17/11/2018 21:43:10 ******/
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
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (1, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-17 00:00:00.000' AS DateTime), N'3', 49)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (2, 2, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-17 00:00:00.000' AS DateTime), N'3', 50)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (3, 3, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-17 00:00:00.000' AS DateTime), N'3', 51)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (4, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-17 00:00:00.000' AS DateTime), N'3', 49)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (5, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-17 21:23:39.000' AS DateTime), N'3', 49)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (6, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-17 21:28:41.000' AS DateTime), N'3', 49)
GO
INSERT [dbo].[Bitacora] ([ID_Bitacora], [ID_Usuario], [Evento], [Descripcion_bitacora], [Fecha_Hora], [Criticidad], [DVH]) VALUES (7, 1, N'LOGIN', N'LOGIN:Ingreso Nombre: admin', CAST(N'2018-11-17 21:30:08.000' AS DateTime), N'3', 49)
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
SET IDENTITY_INSERT [dbo].[Familia] ON 

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
SET IDENTITY_INSERT [dbo].[Familia] OFF
GO
INSERT [dbo].[Familia_Usuario] ([ID_Usuario], [ID_Familia], [Descripcion_familia_usuario]) VALUES (1, 1, N'Administrador General')
GO
INSERT [dbo].[Idioma] ([ID_Idioma], [Nombre_idioma]) VALUES (1, N'Español')
GO
INSERT [dbo].[Idioma] ([ID_Idioma], [Nombre_idioma]) VALUES (2, N'Inglés')
GO
SET IDENTITY_INSERT [dbo].[Patente] ON 

GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (1, N'Alta usuario', N'Ninguna', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (2, N'Modificar usuario', N'Alta usuario', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (3, N'Baja usuario', N'Baja usuario', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (7, N'Asignar usuario-familia', N'Alta usuario', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (8, N'Asignar patente-usuario', N'Alta usuario', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (9, N'Asignar patente-familia', N'Alta usuario', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (11, N'Quitar patente-usuario', N'Asignar patente-usuario', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (12, N'Quitar patente-familia', N'Asignar patente-familia', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (14, N'Quitar usuario-familia', N'Asignar usuario-familia', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (15, N'Alta cliente', N'Alta usuario', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (18, N'Modificar cliente', N'Alta cliente', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (19, N'baja cliente', N'Alta cliente', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (20, N'Alta venta', N'Ninguno', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (21, N'Modificar venta', N'Alta venta', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (22, N'Baja venta', N'Alta venta', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (24, N'Alta reserva', N'Alta venta', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (27, N'Modificar reserva', N'Alta reserva', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (29, N'Baja reserva', N'Alta reserva', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (30, N'Alta producto', N'Ninguno', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (31, N'Modificar producto', N'Modificar producto', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (32, N'Baja producto', N'Alta producto', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (33, N'Alta categoria', N'Alta producto', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (34, N'Modificar categoria', N'Alta categoria', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (35, N'Baja categoria', N'Alta categoria', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (38, N'Backup', N'Alta usuario', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (39, N'Restore', N'Backup', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (40, N'Bitacora', N'Alta usuario', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (41, N'DV', N'Alta usuario', 0)
GO
INSERT [dbo].[Patente] ([ID_Patente], [Nombre_patente], [Condicion], [DVH]) VALUES (42, N'Habilitar usuario', N'Alta usuario', 0)
GO
SET IDENTITY_INSERT [dbo].[Patente] OFF
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (1, 1, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (2, 1, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (3, 1, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (3, 4, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (7, 1, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (8, 1, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (9, 1, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (11, 1, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (12, 1, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (14, 1, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (15, 2, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (18, 2, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (19, 2, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (19, 4, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (20, 2, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (21, 2, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (22, 2, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (22, 4, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (24, 2, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (27, 2, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (29, 2, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (29, 4, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (30, 3, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (31, 3, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (32, 3, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (32, 4, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (33, 3, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (34, 3, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (35, 3, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (35, 4, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (38, 5, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (39, 5, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (40, 5, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (41, 5, 1, 0)
GO
INSERT [dbo].[Patente_Familia] ([ID_Patente], [ID_Familia], [Estado], [DVH]) VALUES (42, 5, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

GO
INSERT [dbo].[Producto] ([ID_Producto], [ID_Categoria], [ID_Reserva], [Descripcion], [Nombre_Producto], [Stock], [Precio_Compra], [Precio_Venta], [imagen], [DVH]) VALUES (1, 1, NULL, N'wstr', N'labe', CAST(12.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), 0xFFD8FFE000104A46494600010101000000000000FFDB0043000906070808080707080707070707070A07070707070F0809070A2011162215111313182828201826251B131321312125292B2E2E2E171F3338332C37282D2E2BFFDB0043010A0A0A0D0D0D0E100D0E2B1915192B2B2B2B2B2B2B2B2B2B372B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2B2BFFC000110800B2011B03012200021101031101FFC400190001010003010000000000000000000000000102040507FFC400161001010100000000000000000000000000000111FFC4001501010100000000000000000000000000000001FFC40014110100000000000000000000000000000000FFDA000C03010002110311003F00F66450100011500001116A202140428802000820000008054540000400111404454044655018A3201D201411500454011510404010400A200800200008000022A000020A8022A020501115010501D101441528214440454010A80208022A00800020000000095528000200082A0200085004001D10450454404004454044540104001000004000000001140400100011500454044501000745152A8808020880854010A80020000080000000000000080008A8022A015150105404001D0454504A540104010440A8200140115000504140415000000004001140400111404450111406F022888A94111510445401000001014000004001014401440000045400400150105404001BA944504A220208022A000000000000008A80800000000000200082A02C4540400045406E31540445A802080000000000000000255018D15000C00050114044C50111501500128008080DBA82008008000000000000000A00228088A000020A0008022A02255400001150111501B485401000000000000000545000000040004000000134040010001000A2008A80D82A0000000000040000005800000000850040000012A280C4A0020000020008200FFFD9, NULL)
GO
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
INSERT [dbo].[Usuario] ([ID_Usuario], [Nombre_Usuario], [Contraseña_usuario], [Nick_Usuario], [Bloqueo], [DNI], [Mail], [Idioma], [DVH]) VALUES (1, N'admin', N'45678', N'Administrador', 0, 11111111, N'admin@yopmail.com', 1, 0)
GO
INSERT [dbo].[Usuario] ([ID_Usuario], [Nombre_Usuario], [Contraseña_usuario], [Nick_Usuario], [Bloqueo], [DNI], [Mail], [Idioma], [DVH]) VALUES (2, N'Ivana Yael Currá', N'45678', N'IvanaYC', 0, 34123042, N'ivanayael@hotmail.co', 1, 49)
GO
INSERT [dbo].[Usuario] ([ID_Usuario], [Nombre_Usuario], [Contraseña_usuario], [Nick_Usuario], [Bloqueo], [DNI], [Mail], [Idioma], [DVH]) VALUES (3, N'Juancarlos', N'4567', N'Juanito', 0, 34129034, N'juanito@yopmail.com', 1, 49)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 1, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 2, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 3, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 7, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 8, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 9, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 11, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 12, 1, 0)
GO
INSERT [dbo].[Usuario_Patente] ([ID_Usuario], [ID_Patente], [Estado], [DVH]) VALUES (1, 14, 1, 0)
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
/****** Object:  StoredProcedure [dbo].[disminuir_stock]    Script Date: 17/11/2018 21:43:11 ******/
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
/****** Object:  StoredProcedure [dbo].[editar_categoria]    Script Date: 17/11/2018 21:43:11 ******/
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
/****** Object:  StoredProcedure [dbo].[editar_cliente]    Script Date: 17/11/2018 21:43:11 ******/
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
/****** Object:  StoredProcedure [dbo].[editar_detalle_venta]    Script Date: 17/11/2018 21:43:11 ******/
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
/****** Object:  StoredProcedure [dbo].[editar_producto]    Script Date: 17/11/2018 21:43:11 ******/
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
/****** Object:  StoredProcedure [dbo].[editar_venta]    Script Date: 17/11/2018 21:43:11 ******/
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
/****** Object:  StoredProcedure [dbo].[eliminar_categoria]    Script Date: 17/11/2018 21:43:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_categoria]
@ID_Categoria integer
as
delete from Categoria where ID_Categoria=@ID_Categoria


GO
/****** Object:  StoredProcedure [dbo].[eliminar_cliente]    Script Date: 17/11/2018 21:43:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_cliente]
@ID_Cliente integer
as
delete from cliente where ID_Cliente=@ID_Cliente


GO
/****** Object:  StoredProcedure [dbo].[eliminar_detalle_venta]    Script Date: 17/11/2018 21:43:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_detalle_venta]
@ID_detalle_venta as integer
as
delete from Detalle_Venta where ID_detalle_venta=@ID_detalle_venta



GO
/****** Object:  StoredProcedure [dbo].[eliminar_producto]    Script Date: 17/11/2018 21:43:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_producto]
@ID_Producto integer
as
delete from Producto where ID_Producto=@ID_Producto



GO
/****** Object:  StoredProcedure [dbo].[eliminar_venta]    Script Date: 17/11/2018 21:43:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_venta]
@ID_Venta as integer
as
delete from Venta where ID_Venta=@ID_Venta



GO
/****** Object:  StoredProcedure [dbo].[insertar_categoria]    Script Date: 17/11/2018 21:43:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_categoria]
@Nombre_Categoria varchar (50)
as
insert into categoria (Nombre_Categoria) values (@Nombre_Categoria)



GO
/****** Object:  StoredProcedure [dbo].[insertar_cliente]    Script Date: 17/11/2018 21:43:11 ******/
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
/****** Object:  StoredProcedure [dbo].[insertar_detalle_venta]    Script Date: 17/11/2018 21:43:11 ******/
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
/****** Object:  StoredProcedure [dbo].[insertar_producto]    Script Date: 17/11/2018 21:43:11 ******/
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
/****** Object:  StoredProcedure [dbo].[insertar_venta]    Script Date: 17/11/2018 21:43:11 ******/
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
/****** Object:  StoredProcedure [dbo].[mostrar_categoria]    Script Date: 17/11/2018 21:43:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[mostrar_categoria]
as
select * from Categoria order by ID_Categoria desc



GO
/****** Object:  StoredProcedure [dbo].[mostrar_cliente]    Script Date: 17/11/2018 21:43:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[mostrar_cliente]
as
select * from cliente order by ID_Cliente desc


GO
/****** Object:  StoredProcedure [dbo].[mostrar_detalle_venta]    Script Date: 17/11/2018 21:43:11 ******/
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
/****** Object:  StoredProcedure [dbo].[mostrar_producto]    Script Date: 17/11/2018 21:43:11 ******/
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
/****** Object:  StoredProcedure [dbo].[mostrar_venta]    Script Date: 17/11/2018 21:43:11 ******/
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
