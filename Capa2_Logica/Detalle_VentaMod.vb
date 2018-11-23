Imports System.Data.SqlClient
Imports Capa1_Datos
Imports Entidad
Public Class Detalle_VentaMod
    Inherits ConexionBD
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_detalle_venta")
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
    Public Function insertar(ByVal dts As vdetalle_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_detalle_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@ID_Venta", dts._Idventa)
            cmd.Parameters.AddWithValue("@ID_Producto", dts._Idproducto)
            cmd.Parameters.AddWithValue("@Cantidad", dts._Cantidad)
            cmd.Parameters.AddWithValue("@Precio_unitario", dts._Precio_unitario)



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

    Public Function editar(ByVal dts As vdetalle_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_detalle_venta")        'Llamo al procedimiento de sql que creamos de modificar'
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@ID_detalle_venta", dts._Iddetalle_venta)
            cmd.Parameters.AddWithValue("@ID_Venta", dts._Idventa)
            cmd.Parameters.AddWithValue("@ID_Producto", dts._Idproducto)
            cmd.Parameters.AddWithValue("@Cantidad", dts._Cantidad)
            cmd.Parameters.AddWithValue("@Precio_unitario", dts._Precio_unitario)
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
    Public Function eliminar(ByVal dts As vdetalle_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@ID_detalle_venta", SqlDbType.NVarChar, 50).Value = dts._Iddetalle_venta
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


    Public Function aumentar_stock(ByVal dts As vdetalle_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("aumentar_stock")        'Llamo al procedimiento de sql que creamos de modificar'
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@ID_Producto", dts._Idproducto)
            cmd.Parameters.AddWithValue("@Cantidad", dts._Cantidad)
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

    Public Function disminuir_stock(ByVal dts As vdetalle_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("disminuir_stock")        'Llamo al procedimiento de sql que creamos de modificar'
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn


            cmd.Parameters.AddWithValue("@ID_Producto", dts._Idproducto)
            cmd.Parameters.AddWithValue("@Cantidad", dts._Cantidad)
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
End Class
