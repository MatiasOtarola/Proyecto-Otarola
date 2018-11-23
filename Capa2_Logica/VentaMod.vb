Imports System.Data.SqlClient
Imports Capa1_Datos
Imports Entidad
Public Class VentaMod
    Inherits ConexionBD
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_venta")
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
    Public Function insertar(ByVal dts As vventa) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@ID_Cliente", dts._Idcliente)
            cmd.Parameters.AddWithValue("@Fecha_Venta", dts._Fecha_venta)
            cmd.Parameters.AddWithValue("@Tipo", dts._tipo)
            cmd.Parameters.AddWithValue("@DNI", dts._DNI)
            cmd.Parameters.AddWithValue("@Nro_Factura", dts._Nro_Factura)

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

    Public Function editar(ByVal dts As vventa) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_venta")        'Llamo al procedimiento de sql que creamos de modificar'
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@ID_Venta", dts._Idventa)
            cmd.Parameters.AddWithValue("@ID_Cliente", dts._Idcliente)
            cmd.Parameters.AddWithValue("@Fecha_Venta", dts._Fecha_venta)
            cmd.Parameters.AddWithValue("@Tipo", dts._tipo)
            cmd.Parameters.AddWithValue("@DNI", dts._DNI)
            cmd.Parameters.AddWithValue("@Nro_Factura", dts._Nro_Factura)

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
    Public Function eliminar(ByVal dts As vventa) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@ID_Venta", SqlDbType.NVarChar, 50).Value = dts._Idventa
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
