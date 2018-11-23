create proc editar_cliente
@ID_Cliente integer,
@Nombre varchar (250),
@Apellido varchar (250),
@Mail varchar (250),
@DNI varchar (8)
as
update cliente set Nombre=@Nombre, Apellido=@Apellido,Mail=@Mail, DNI=@DNI
where ID_Cliente=@ID_Cliente

GO


create proc eliminar_cliente
@ID_Cliente integer
as
delete from cliente where ID_Cliente=@ID_Cliente
GO

Create proc mostrar_categoria
as
select * from Categoria order by ID_Categoria desc

GO

create proc insertar_categoria
@Nombre_Categoria varchar (50)
as
insert into categoria (Nombre_Categoria) values (@Nombre_Categoria)

GO

create proc editar_categoria
@ID_Categoria integer,
@Nombre_Categoria varchar (50)
as
update Categoria set Nombre_Categoria=@Nombre_Categoria
where ID_Categoria=@ID_Categoria
GO

create proc eliminar_categoria
@ID_Categoria integer
as
delete from Categoria where ID_Categoria=@ID_Categoria
GO

create proc mostrar_producto
as 
select Producto.ID_Producto, Producto.ID_Categoria, Categoria.Nombre_Categoria,Producto.Nombre_Producto,
Producto.Descripcion,Producto.Stock,Producto.Precio_Compra, Producto.Precio_Venta,
Producto.imagen
from Producto inner join Categoria on Producto.ID_Categoria=Categoria.ID_Categoria
order by Producto.ID_Producto desc
GO

create proc insertar_producto
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

create proc editar_producto
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

create proc eliminar_producto
@ID_Producto integer
as
delete from Producto where ID_Producto=@ID_Producto

GO
