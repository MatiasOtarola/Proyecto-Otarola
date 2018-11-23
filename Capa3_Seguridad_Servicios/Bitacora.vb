Imports Capa1_Datos
Imports System.Data
Imports System.Data.SqlClient

Public Class Bitacora
    Private _ID_Bitacora As Integer
    Private _ID_Usuario As Integer
    Private _Evento As String
    Private _Descripcion_bitacora As String
    Private _Fecha_Hora As Date
    Private _Criticidad As String
    Private _DVH As String
    Public Property ID_Bitacora() As Integer
        Get
            Return _ID_Bitacora
        End Get
        Set(ByVal value As Integer)
            _ID_Bitacora = value
        End Set
    End Property
    Public Property ID_Usuario() As Integer
        Get
            Return _ID_Usuario
        End Get
        Set(ByVal value As Integer)
            _ID_Usuario = value
        End Set
    End Property
    Public Property Evento() As String
        Get
            Return _Evento
        End Get
        Set(ByVal value As String)
            _Evento = value
        End Set
    End Property
    Public Property Descripcion_bitacora() As String
        Get
            Return _Descripcion_bitacora
        End Get
        Set(ByVal value As String)
            _Descripcion_bitacora = value
        End Set
    End Property
    Public Property Fecha_Hora() As Date
        Get
            Return _Fecha_Hora
        End Get
        Set(ByVal value As Date)
            _Fecha_Hora = value
        End Set
    End Property
    Public Property Criticidad() As String
        Get
            Return _Criticidad
        End Get
        Set(ByVal value As String)
            _Criticidad = value
        End Set
    End Property
    Public Property DVH() As String
        Get
            Return _DVH
        End Get
        Set(ByVal value As String)
            _DVH = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal ID_Bitacora As Integer, ByVal ID_Usuario As Integer, ByVal Evento As String, ByVal Descripcion_bitacora As String, ByVal Fecha_Hora As Date, ByVal Criticidad As String, ByVal DVH As String)
        Me.ID_Bitacora = ID_Bitacora
        Me.ID_Usuario = ID_Usuario
        Me.Evento = Evento
        Me.Descripcion_bitacora = Descripcion_bitacora
        Me.Fecha_Hora = Fecha_Hora
        Me.Criticidad = Criticidad
        Me.DVH = DVH
    End Sub
    Public Function Seleccionar(ByVal ID_Bitacora As Integer)
        Dim Consulta As String
        If ID_Bitacora = 0 Then
            Consulta = "SELECT * from Bitacora"
        Else
            Consulta = "SELECT * from Bitacora where ID_Bitacora=" & ID_Bitacora
        End If
        Dim Datos As New Acceso
        Dim DS As DataSet
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function crearNuevaBitacora() As Integer
        Dim Datos As New Acceso
        Dim Consulta As String = ""
        Consulta = "SELECT MAX(ID_Bitacora) from Bitacora"
        crearNuevaBitacora = Datos.EjecutarConsultaDR(Consulta)
    End Function
    Public Sub AccesarBitacora(ByVal ID_Usuario As Integer, ByVal Evento As String, ByVal Descripcion_bitacora As String, ByVal Fecha_Hora As Date, ByVal Criticidad As String, ByVal DVH As String)
        Dim Datos As New Acceso
        Dim Consulta As String = ""
        ' Guarda en la BD
        Consulta = "INSERT INTO Bitacora ([ID_Usuario],[Evento],[Descripcion_bitacora],[Fecha_Hora],[Criticidad],[DVH]) VALUES (" & ID_Usuario & ",'" & Evento & "','" & Descripcion_bitacora & "','" & Fecha_Hora & "','" & Criticidad & "', '" & DVH & "')"
        Datos.EjecutarConsultaDS(Consulta)
    End Sub
    Public Sub ActualizarDVH(ByVal query As String)
        Dim Datos As New Acceso
        Datos.EjecutarConsultaNonQuery(query)
    End Sub
    Public Function Visualizar()
        Dim Datos As New Acceso
        Return Datos.EjecutarConsultaDS("select ID_Bitacora as NroBitacora, Usuario.Nick_Usuario as Usuario, Bitacora.evento as Evento, Bitacora.Descripcion_bitacora as Descripción, Format(Fecha_Hora, '" & "ddddd" & "') as Fecha, Format(Fecha_Hora, '" & "HH:mm:ss" & "') as Hora,  Bitacora.Criticidad FROM Bitacora LEFT OUTER JOIN Usuario ON Bitacora.ID_Usuario = Usuario.ID_Usuario")
    End Function
    Public Function BuscarTablaDVH(ByVal query As String, ByVal cod As String) As String
        Dim Datos As New Acceso
        Dim a As String
        a = Datos.EjecutarConsultaDR2(query, cod)
        Return a
    End Function

End Class
