Imports Capa1_Datos
Imports System.Data
Imports System.Data.OleDb
Public Class Patente
    Private _ID_Patente As Integer
    Private _Nombre_Patente As String
    Private _Condicion As String
    Private _DVH As Integer
    Public Property ID_patente() As Integer
        Get
            Return _ID_patente
        End Get
        Set(ByVal value As Integer)
            _ID_patente = value
        End Set
    End Property
    Public Property Nombre_Patente() As String
        Get
            Return _Nombre_Patente
        End Get
        Set(ByVal value As String)
            _Nombre_Patente = value
        End Set
    End Property
    Public Property Condicion() As String
        Get
            Return _Condicion
        End Get
        Set(ByVal value As String)
            _Condicion = value
        End Set
    End Property
    Public Property DVH() As Integer
        Get
            Return _DVH
        End Get
        Set(ByVal value As Integer)
            _DVH = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal ID_Patente As Integer, ByVal Nombre_Patente As String, ByVal Condicion As String, ByVal DVH As Integer)
        Me.ID_patente = ID_Patente
        Me.Nombre_Patente = Nombre_Patente
        Me.Condicion = Condicion
        Me.DVH = DVH
    End Sub
   Public Function crearNuevaPatente() As Integer
        Dim Datos As New Acceso
        Dim Consulta As String
        Consulta = "Select max(ID_Patente) from Patente"
        crearNuevaPatente = Datos.EjecutarConsultaDR(Consulta) + 1
    End Function
    Public Sub AsignarPatente(ByVal query As String)
        Dim Datos As New Acceso
        Datos.EjecutarConsultaNonQuery(query)
    End Sub
    Public Sub AsignarUsuario(ByVal ID_Usuario As Integer, ByVal ID_Patente As Integer, ByVal Estado As Integer, ByVal DVH As Integer)
        Dim Datos As New Acceso
        Dim Consulta As String
        Consulta = "Insert into Usuario_Patente values (" & ID_Usuario & "," & ID_Patente & ",'" & Estado & "','" & DVH & "')"
        Datos.EjecutarConsultaDS(Consulta)
    End Sub
    Public Function ActualizarPatente_Usuario(ByVal ID_Usuario As Integer, ByVal ID_Patente As Integer, ByVal Estado As Integer, ByVal DVH As Integer)
        Dim Datos As New Acceso
        Dim DS As DataSet
        Dim Consulta As String
        Consulta = "Update Usuario_Patente set ID_Patente =" & ID_Patente & ",Estado=" & Estado & ",DVH= '" & DVH & "' where ID_Usuarios=" & ID_Usuario & ""
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function Buscar(ByVal Nombre_Patente As String)
        Dim Datos As New Acceso
        Dim DS As DataSet
        Dim Consulta As String
        Consulta = "Select * from Patente where Nombre_Patente='" & Nombre_Patente & "'"
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function ActualizarFamilia_Patente(ByVal query As String, ByVal cod As String) As String
        Dim Datos As New Acceso
        Dim a As String
        a = Datos.EjecutarConsultaDR2(query, cod)
        Return a
    End Function
    Public Sub AsignarFamilia(ByVal ID_Familia As Integer, ByVal ID_patente As Integer, ByVal Estado As Integer, ByVal DVH As Integer)
        Dim Datos As New Acceso
        Dim DS As DataSet
        Dim Consulta As String
        Consulta = "Insert into Patente_Familia values (" & ID_patente & "," & ID_Familia & "," & Estado & ",'" & DVH & "')"
        DS = Datos.EjecutarConsultaDS(Consulta)
    End Sub
    Public Function Alta(ByVal ID_patente As Integer, ByVal Nombre_Patente As String, ByVal Condicion As String, ByVal DVH As String)
        Dim Datos As New Acceso
        Dim DS As DataSet
        Dim Consulta As String
        Consulta = "Insert into Patente values (" & ID_patente & ",'" & Nombre_Patente & "','" & Condicion & "','" & DVH & "')"
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function Modificacion(ByVal ID_patente As Integer, ByVal Nombre_Patente As String, ByVal Condicion As String, ByVal DVH As String)
        Dim Datos As New Acceso
        Dim DS As DataSet
        Dim Consulta As String
        Consulta = "Update Patente set Nombre_patente ='" & Nombre_Patente & "',Condicion ='" & Condicion & "',DVH='" & DVH & "' where ID_Patente = " & ID_patente & ""
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function Baja(ByVal ID_Patente As Integer)
        Dim Datos As New Acceso
        Dim DS As DataSet
        Dim Consulta As String
        Consulta = "DELETE FROM Patente where ID_Patente=" & ID_patente
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function AsignarPerfil(ByVal ID_patente As Integer)
        Dim Datos As New Acceso
        Dim DS As DataSet
        Dim Consulta As String
        If ID_patente = 0 Then
            Consulta = "select * from Patente"
        Else
            Consulta = "select * from Patente where ID_Patente=" & ID_patente
        End If
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function

    Public Sub cargar_listbox(ByVal listbox As Windows.Forms.ListBox, ByVal sql As String, ByVal tabla As String)
        Dim Datos As New Acceso
        Dim ds As New DataSet
        ds = Datos.EjecutarConsultaDSTabla(sql, tabla)
        Try
            ' asignar el DataSource al combobox
            listbox.DataSource = ds.Tables(0)
            ' Asignar el campo a la propiedad DisplayMember del combo 
            listbox.DisplayMember = ds.Tables(0).Columns(0).Caption.ToString
        Catch ex As Exception

        End Try
    End Sub
End Class

