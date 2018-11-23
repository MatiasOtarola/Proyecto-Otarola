create proc insertar_venta
@ID_Cliente as integer,
@Fecha_Venta as date,
@Tipo as varchar (250),
@DNI as varchar (8),
@Nro_Factura as integer
as
insert into Venta (ID_Cliente,Fecha_Venta,Tipo,DNI, Nro_Factura)
values (@ID_Cliente,@Fecha_Venta,@Tipo,@DNI, @Nro_Factura)

GO

create proc editar_venta
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

create proc eliminar_venta
@ID_Venta as integer
as
delete from Venta where ID_Venta=@ID_Venta

GO


Create proc mostrar_venta
as
SELECT        dbo.Venta.ID_Venta, dbo.Venta.ID_Cliente, dbo.Cliente.Apellido, dbo.Cliente.DNI, dbo.Venta.Fecha_Venta, dbo.Venta.Tipo, dbo.Venta.DNI AS Expr1, dbo.Venta.Nro_Factura
FROM            dbo.Venta INNER JOIN
                         dbo.Cliente ON dbo.Venta.ID_Cliente = dbo.Cliente.ID_Cliente

go


create proc insertar_detalle_venta
@ID_Venta as integer,
@ID_Producto as integer,
@Cantidad as decimal (18,2),
@Precio_Unitario as decimal (18,2)
as
insert into Detalle_Venta (ID_Venta,ID_Producto,Cantidad,Precio_unitario)
values (@ID_Venta,@ID_Producto,@Cantidad,@Precio_unitario)

GO

create proc editar_detalle_venta
@ID_detalle_venta as integer,
@ID_Venta as integer,
@ID_Producto as integer,
@Cantidad as decimal (18,2),
@Precio_unitario as decimal (18,2)
as
update Detalle_Venta set ID_Venta=@ID_Venta,ID_Producto=@ID_Producto,Cantidad=@Cantidad,Precio_unitario=@Precio_unitario
where ID_detalle_venta=@ID_detalle_venta

GO

create proc eliminar_detalle_venta
@ID_detalle_venta as integer
as
delete from Detalle_Venta where ID_detalle_venta=@ID_detalle_venta

GO

Create proc mostrar_detalle_venta
as
select * from Detalle_Venta order by ID_detalle_venta desc
go

create proc aumentar_stock
@ID_Producto as integer,
@Cantidad as decimal (18,2)
as
update Producto set Stock=Stock+@Cantidad where ID_Producto=@ID_Producto

GO

create proc disminuir_stock
@ID_Producto as integer,
@Cantidad as decimal (18,2)
as
update Producto set Stock=Stock-@Cantidad where ID_Producto=@ID_Producto

GO