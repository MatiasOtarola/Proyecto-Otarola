USE [SistemaVentas]
GO
/****** Object:  StoredProcedure [dbo].[mostrar_venta]    Script Date: 11/13/2018 3:15:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[mostrar_venta]
as
SELECT        dbo.Venta.ID_Venta, dbo.Venta.ID_Cliente, dbo.Cliente.Apellido, dbo.Cliente.DNI, dbo.Venta.Fecha_Venta, dbo.Venta.Tipo, dbo.Venta.DNI AS Expr1, dbo.Venta.Nro_Factura
FROM            dbo.Venta INNER JOIN
                         dbo.Cliente ON dbo.Venta.ID_Cliente = dbo.Cliente.ID_Cliente
						 order by dbo.Venta.ID_Venta desc