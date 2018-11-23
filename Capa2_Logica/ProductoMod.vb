Imports System.Data.SqlClient
Imports Capa1_Datos
Imports Entidad
Public Class ProductoMod
    Inherits ConexionBD
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function
    Public Function insertar(ByVal dts As vproducto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@ID_Categoria", dts._Idcategoria)
            cmd.Parameters.AddWithValue("@Nombre_Producto", dts._Nombre_Producto)
            cmd.Parameters.AddWithValue("@Descripcion", dts._Descripcion)
            cmd.Parameters.AddWithValue("@Stock", dts._stock)
            cmd.Parameters.AddWithValue("@Precio_Compra", dts.Precio_comprap)
            cmd.Parameters.AddWithValue("@Precio_Venta", dts.precio_ventap)
            cmd.Parameters.AddWithValue("@Imagen", dts._Imagen)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function
    Public Function editar(ByVal dts As vproducto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_producto")        'Llamo al procedimiento de sql que creamos de modificar'
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@ID_Producto", dts._Idproducto)
            cmd.Parameters.AddWithValue("@ID_Categoria", dts._Idcategoria)
            cmd.Parameters.AddWithValue("@Nombre_Producto", dts._Nombre_Producto)
            cmd.Parameters.AddWithValue("@Descripcion", dts._Descripcion)
            cmd.Parameters.AddWithValue("@Stock", dts._stock)
            cmd.Parameters.AddWithValue("@Precio_Compra", dts.Precio_comprap)
            cmd.Parameters.AddWithValue("@Precio_Venta", dts.precio_ventap)
            cmd.Parameters.AddWithValue("@Imagen", dts._Imagen)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function
    Public Function eliminar(ByVal dts As vproducto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_producto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@ID_Producto", SqlDbType.NVarChar, 50).Value = dts._Idproducto
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
