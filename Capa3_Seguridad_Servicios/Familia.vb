Imports System.Data
Imports System.Data.OleDb
Imports Capa1_Datos
Public Class Familia
    Private _ID_Familia As Integer
    Private _Nombre_Familia As String
    Private _Descripcion_familia As String

    Public Property ID_Familia() As Integer
        Get
            Return _ID_Familia
        End Get
        Set(ByVal value As Integer)
            _ID_Familia = value
        End Set
    End Property
    Public Property Nombre_Familia() As String
        Get
            Return _Nombre_Familia
        End Get
        Set(ByVal value As String)
            _Nombre_Familia = value
        End Set
    End Property
    Public Property Descripcion_Familia() As String
        Get
            Return _Descripcion_familia
        End Get
        Set(ByVal value As String)
            _Descripcion_familia = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal ID_Familia As Integer, ByVal Nombre_Familia As String, ByVal Descripcion_Familia As String)
        Me.ID_Familia = ID_Familia
        Me.Nombre_Familia = Nombre_Familia
        Me.Descripcion_Familia = Descripcion_Familia
    End Sub
    Public Function AsignarPerfil(ByVal ID_Familia As Integer) As DataSet
        Dim Consulta As String
        If ID_Familia = 0 Then
            Consulta = "Select * from Familia"
        Else
            Consulta = "Select * from Familia where ID_Familia=" & ID_Familia
        End If
        Dim Datos As New Acceso
        Dim DS As New DataSet
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function crearNuevaFamilia() As Integer
        Dim Datos As New Acceso
        Dim Consulta As String = ""
        Consulta = "SELECT MAX(ID_Familia) from Familia"
        crearNuevaFamilia = Datos.EjecutarConsultaDR(Consulta) + 1
    End Function
    Public Sub Alta(ByVal ID_Familia As Integer, ByVal Nombre_Familia As String, ByVal Descripcion_Familia As String)
        Dim Datos As New Acceso
        Dim Consulta As String
        Consulta = "INSERT INTO Familia values (" & ID_Familia & ",'" & Nombre_Familia & "','" & Descripcion_Familia & "')"
        Datos.EjecutarConsultaDS(Consulta)
    End Sub
    Public Function Baja(ByVal ID_Familia As Integer)
        Dim Datos As New Acceso
        Dim DS As DataSet
        Dim Consulta As String
        Consulta = "Delete from Familia where ID_Familia=" & ID_Familia & ""
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function Modificacion(ByVal ID_Familia As Integer, ByVal Nombre_Familia As String, ByVal Descripcion_Familia As String)
        Dim Datos As New Acceso
        Dim DS As DataSet
        Dim Consulta As String
        Consulta = "UPDATE Familia SET Nombre_familia = '" & Nombre_Familia & "', Descripcion_familia = '" & Descripcion_Familia & "' WHERE ID_Familia =  " & ID_Familia
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function AsignarPatente(ByVal Nombre_Familia As String)
        Dim Consulta As String
        Dim Datos As New Acceso
        Consulta = "SELECT Familia.*, Patente_Familia.*, Patente.* FROM Familia LEFT JOIN Patente_Familia ON Familia.ID_Familia = Patente_Familia.ID_Familia LEFT JOIN Patente ON Patente_Familia.ID_Patente = Patente.ID_Patente and Familia.Nombre_familia = '" & Nombre_Familia & "'"
        Dim DS As DataSet
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function Buscar(ByVal Nombre_Familia As String)
        Dim Consulta As String
        Dim Datos As New Acceso
        Consulta = "Select * from Familia where  Nombre_familia='" & Nombre_Familia & "'"
        Dim DS As DataSet
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
   Public Sub AsignarUsuario(ByVal query As String)
        Dim Datos As New Acceso
        Datos.EjecutarConsultaNonQuery(query)
    End Sub
    Public Function Transferir(ByVal ID_Usuario As Integer)
        Dim Datos As New Acceso
        Dim DS As DataSet
        Dim Consulta As String
        Consulta = "update Familia_Usuario set Familia_Usuario.ID_Familia = 1 where Familia_Usuario.ID_Usuario =" & ID_Usuario
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function Cargar_Listbox_Usuarios(ByVal query As String, ByVal cod As String) As String
        Dim Datos As New Acceso
        Dim a As String
        a = Datos.EjecutarConsultaDR2(query, cod)
        Return a
    End Function
  
    Public Sub Cargar_Listbox_Familia_Patente(ByVal listbox As Windows.Forms.ListBox, ByVal sql As String, ByVal tabla As String)
        Dim Datos As New Acceso
        Dim ds As New DataSet
        ds = Datos.EjecutarConsultaDSTabla(sql, tabla)
        Try
            ' asignar el DataSource al combobox
            listbox.DataSource = ds.Tables(0)
            ' Asignar el campo a la propiedad DisplayMember del combo 
            listbox.ValueMember = ds.Tables(0).Columns(0).Caption.ToString
            listbox.DisplayMember = ds.Tables(0).Columns(0).Caption.ToString

        Catch ex As Exception

        End Try
    End Sub
    Public Function Eliminar_Familia_Patente(ByVal ID_Familia As Integer)
        Dim Datos As New Acceso
        Dim DS As DataSet
        Dim consulta As String
        consulta = "Delete from Patente_Familia where ID_Familia=" & ID_Familia
        DS = Datos.EjecutarConsultaDS(consulta)
        Return DS
    End Function
    Public Function SeleccionarUsuario(ByVal ID_Familia As Integer)
        Dim Datos As New Acceso
        Dim DS As DataSet
        Dim consulta As String
        consulta = "select * from Familia_Usuario where ID_Familia =" & ID_Familia
        DS = Datos.EjecutarConsultaDS(consulta)
        Return DS
    End Function
    Public Sub cargartabla(ByVal list As Windows.Forms.CheckedListBox, ByVal query1 As String, ByVal tabla As String)
        Dim Datos As New Acceso
        Dim dsview As DataSet
        dsview = Datos.EjecutarConsultaDSTabla(query1, tabla)
        Dim i As Integer = 0
        Dim a As Integer
        For i = 0 To dsview.Tables(0).Rows.Count - 1
            a = dsview.Tables(0).Rows(i).Item(0)
            list.SetItemChecked(a - 1, True)
        Next
    End Sub
    Public Sub modifica(ByVal sql As String, ByVal tabla As String)
        Dim Datos As New Acceso
        Dim ds As New DataSet
        ds = Datos.EjecutarConsultaDSTabla(sql, tabla)
        Me.ID_Familia = ds.Tables(tabla).Rows(0).Item(0)
        Me.Nombre_Familia = ds.Tables(tabla).Rows(0).Item(1)
        Me.Descripcion_Familia = ds.Tables(tabla).Rows(0).Item(2)
    End Sub
End Class
