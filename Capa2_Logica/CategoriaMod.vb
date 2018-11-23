Imports System.Data.SqlClient
Imports Capa1_Datos
Imports Entidad
Public Class CategoriaMod
    Inherits ConexionBD
    Dim cmd As New SqlCommand
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_categoria")
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
    Public Function insertar(ByVal dts As vcategoria) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_categoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Nombre_categoria", dts.Nombrecategoria)


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

    Public Function editar(ByVal dts As vcategoria) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_categoria")        'Llamo al procedimiento de sql que creamos de modificar'
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Idcategoria", dts._IDcategoria)
            cmd.Parameters.AddWithValue("@Nombre_categoria", dts.Nombrecategoria)


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
    Public Function eliminar(ByVal dts As vcategoria) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_categoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@Idcategoria", SqlDbType.NVarChar, 50).Value = dts._IDcategoria
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


