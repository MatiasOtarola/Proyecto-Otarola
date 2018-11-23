Imports Capa1_Datos
Imports System.Data
Imports System.Data.OleDb
Public Class Login
    Private _ID_Bitacora As Integer
    Private _ID_Usuario As Integer
    Private _Evento As Integer
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
    Public Property Evento() As Integer
        Get
            Return _Evento
        End Get
        Set(ByVal value As Integer)
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
    Public Function SeleccionarUsuario(ByVal Nombre_Usuario As String)
        Dim Datos As New Acceso
        Dim Consulta As String = ""
        Consulta = "SELECT * FROM Usuario where Nombre_Usuario='" & Nombre_Usuario & "'"
        Dim DS As DataSet
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function MAXIMO() As Integer
        Dim Datos As New Acceso
        Dim Consulta As String = ""
        Consulta = "SELECT max(ID_Usuario) FROM Usuario"
        MAXIMO = Datos.EjecutarConsultaDR(Consulta) + 1
    End Function
    Public Function ValidarPersonal() As Integer
        Dim Datos As New Acceso
        Dim Consulta As String = ""
        Consulta = "SELECT max(ID_Usuario) FROM Usuario"
        ValidarPersonal = Datos.EjecutarConsultaDR(Consulta)
    End Function
    Public Sub HabilitarLogin(ByVal ID_Usuario As Integer, ByVal Evento As String, ByVal Descripcion_bitacora As String, ByVal Fecha_Hora As Date, ByVal Criticidad As Integer, ByVal DVH As Integer)
        Dim Datos As New Acceso
        Dim DS As DataSet
        Dim Consulta As String
        Consulta = "Insert into Bitacora ([ID_Usuario],[Evento],[Descripcion_bitacora],[Fecha_Hora],[Criticidad],[DVH]) values (" & ID_Usuario & ",'" & Evento & "','" & Descripcion_bitacora & "', '" & Fecha_Hora & "'," & Criticidad & "," & DVH & ")"
        DS = Datos.EjecutarConsultaDS(Consulta)
    End Sub
    Public Function CerrarSesion(ByVal ID_Usuario As Integer, ByVal Bloqueo As Integer)
        Dim Datos As New Acceso
        Dim DS As DataSet
        Dim Consulta As String
        Consulta = "UPDATE Usuario SET Bloqueo = 0 where ID_Usuario =" & ID_Usuario
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
End Class
