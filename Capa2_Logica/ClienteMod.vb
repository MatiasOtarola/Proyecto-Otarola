Imports System.Data.SqlClient
Imports System.Data
Imports Capa1_Datos
Imports Entidad
Public Class ClienteMod
    Inherits ConexionBD
    Dim cmd As New SqlCommand
    Private _ID_Cliente As Integer
    Private _Nombre As String
    Private _Apellido As String
    Private _DNI As String
    Private _Mail As String
    Private _DVH As Integer
  

    Property ID_Cliente() As Integer
        Get
            Return _ID_Cliente
        End Get
        Set(ByVal value As Integer)
            If value = "" Then
                _ID_Cliente = value
            End If
        End Set
    End Property
    Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Property Apellido() As String
        Get
            Return _Apellido
        End Get
        Set(ByVal value As String)
            _Apellido = value
        End Set
    End Property
    Property DNI() As String
        Get
            Return _DNI
        End Get
        Set(ByVal value As String)
            _DNI = value
        End Set
    End Property
    Property Mail() As String
        Get
            Return _Mail
        End Get
        Set(ByVal value As String)
            _Mail = value
        End Set
    End Property
    Property DVH() As Integer
        Get
            Return _DVH
        End Get
        Set(ByVal value As Integer)
            _DVH = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal ID_Cliente As Integer, ByVal Nombre As String, ByVal Apellido As String, ByVal DNI As String, ByVal Mail As String, ByVal DVH As Integer)
        Me.ID_Cliente = ID_Cliente
        Me.Nombre = Nombre
        Me.Apellido = Apellido
        Me.DNI = DNI
        Me.Mail = Mail
        Me.DVH = DVH
    End Sub
    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_cliente")
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
    Public Function insertar(ByVal dts As vcliente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@Nombre", dts._Nombre)
            cmd.Parameters.AddWithValue("@Apellido", dts._Apellido)
            cmd.Parameters.AddWithValue("@Mail", dts._Mail)
            cmd.Parameters.AddWithValue("@DNI", dts._DNI)

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

    Public Function editar(ByVal dts As vcliente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_cliente")        'Llamo al procedimiento de sql que creamos de modificar'
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@ID_Cliente", dts.ID)
            cmd.Parameters.AddWithValue("@Nombre", dts._Nombre)
            cmd.Parameters.AddWithValue("@Apellido", dts._Apellido)
            cmd.Parameters.AddWithValue("@DNI", dts._DNI)
            cmd.Parameters.AddWithValue("@Mail", dts._Mail)


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
    Public Function eliminar(ByVal dts As vcliente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.Add("@ID_Cliente", SqlDbType.NVarChar, 50).Value = dts.ID
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
    Public Function AsignarPerfil(ByVal ID_Cliente As Integer)
        Dim Consulta As String
        If ID_Cliente = 0 Then
            Consulta = "select * from Cliente"
        Else
            Consulta = "select * from Cliente where ID_Cliente=" & ID_Cliente
        End If
        Dim Datos As New Acceso
        Dim DS As New DataSet
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
End Class
