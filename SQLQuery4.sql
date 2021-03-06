USE [SistemaVentas]
GO
/****** Object:  StoredProcedure [dbo].[mostrar_detalle_venta]    Script Date: 11/13/2018 3:17:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[mostrar_detalle_venta]
as
SELECT        dbo.Detalle_Venta.ID_detalle_venta, dbo.Detalle_Venta.ID_Venta, dbo.Detalle_Venta.ID_Producto, dbo.Producto.Nombre_Producto, dbo.Detalle_Venta.Cantidad, dbo.Detalle_Venta.Precio_unitario
FROM            dbo.Detalle_Venta INNER JOIN
                         dbo.Producto ON dbo.Detalle_Venta.ID_Producto = dbo.Producto.ID_Producto order by dbo.Detalle_Venta.ID_detalle_venta desc
