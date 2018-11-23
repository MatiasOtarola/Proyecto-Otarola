Imports System.Data
Imports System.Data.OleDb
Imports Capa1_Datos
Public Class Usuario
    Implements IUsuario
    Private _ID_Usuario As Integer
    Private _Nombre_Usuario As String
    Private _Contraseña_usuario As String
    Private _Nick_Usuario As String
    Private _Bloqueo As Integer
    Private _DNI As String
    Private _Mail As String
    Private _Idioma As Integer
    Private _DVH As Integer

    Property ID_Usuario() As Integer
        Get
            Return _ID_Usuario
        End Get
        Set(ByVal value As Integer)
            If value = "" Then
                _ID_Usuario = value
            End If
        End Set
    End Property
    Property Nombre_Usuario() As String
        Get
            Return _Nombre_Usuario
        End Get
        Set(ByVal value As String)
            _Nombre_Usuario = value
        End Set
    End Property
    Property Contraseña_usuario() As String
        Get
            Return _Contraseña_usuario
        End Get
        Set(ByVal value As String)
            _Contraseña_usuario = value
        End Set
    End Property
    Property Nick_Usuario() As String
        Get
            Return _Nick_Usuario
        End Get
        Set(ByVal value As String)
            _Nick_Usuario = value
        End Set
    End Property
    Property Bloqueo() As Integer
        Get
            Return _Bloqueo
        End Get
        Set(ByVal value As Integer)
            If value = "" Then
                _Bloqueo = value
            End If
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
    Property Idioma() As Integer
        Get
            Return _Idioma
        End Get
        Set(ByVal value As Integer)
            _Idioma = value
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
    Public Sub New(ByVal ID_Usuario As Integer, ByVal Nombre_Usuario As String, ByVal Contraseña_usuario As String, ByVal Nick_Usuario As String, ByVal Bloqueo As Integer, ByVal DNI As String, ByVal Mail As String, ByVal Idioma As Integer, ByVal DVH As Integer)
        Me.ID_Usuario = ID_Usuario
        Me.Nombre_Usuario = Nombre_Usuario
        Me.Contraseña_usuario = Contraseña_usuario
        Me.Nick_Usuario = Nick_Usuario
        Me.Bloqueo = Bloqueo
        Me.DNI = DNI
        Me.Mail = Mail
        Me.Idioma = Idioma
        Me.DVH = DVH
    End Sub
    Public Sub Alta(ByVal ID_Usuario As Integer, ByVal Nombre_Usuario As String, ByVal Contraseña_usuario As String, ByVal Nick_Usuario As String, ByVal Bloqueo As Integer, ByVal DNI As String, ByVal Mail As String, ByVal Idioma As Integer, ByVal DVH As Integer)
        Dim Datos As New Acceso
        Dim Consulta As String
        ' Guarda en la Base de Datos
        Consulta = "INSERT INTO Usuario Values (" & ID_Usuario & ",'" & Nombre_Usuario & "','" & Contraseña_usuario & "','" & Nick_Usuario & "'," & Bloqueo & ",'" & DNI & "','" & Mail & "'," & Idioma & ",'" & DVH & "')"
        Datos.EjecutarConsultaDS(Consulta)
    End Sub
    Public Function Baja(ByVal ID_Usuario As Integer)
        Dim Datos As New Acceso
        Dim DS As DataSet
        Dim Consulta As String
        ' Borrar en la Base De Datos 
        Consulta = "Delete from Usuario WHERE ID_Usuario =" & ID_Usuario
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function ModificarContraseña(ByVal ID_Usuario As Integer, ByVal Contraseña_usuario As String)
        Dim Datos As New Acceso
        Dim DS As DataSet
        Dim Consulta As String
        ' Actualizar la contraseña de la base de datos 
        Consulta = "UPDATE Usuario SET Contraseña_usuario = '" & Contraseña_usuario & "' WHERE ID_Usuario= " & ID_Usuario
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function Modificacion(ByVal ID_Usuario As Integer, ByVal Nombre_Usuario As String, ByVal Contraseña_usuario As String, ByVal Nick_Usuario As String, ByVal Bloqueo As Integer, ByVal DNI As String, ByVal Mail As String, ByVal Idioma As Integer, ByVal DVH As Integer)
        Dim Datos As New Acceso
        Dim DS As DataSet
        Dim Consulta As String
        ' Actualziar la Base de Datos
        Consulta = "UPDATE Usuario SET Nombre_Usuario = '" & Nombre_Usuario & "', Contraseña_usuario = '" & Contraseña_usuario & "', Nick_Usuario = '" & Nick_Usuario & "',Bloqueo =" & Bloqueo & ", DNI = '" & DNI & "', Mail = '" & Mail & "', Idioma =" & Idioma & ", DVH = '" & DVH & "' where ID_Usuario =" & ID_Usuario
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function ValidarContraseña(ByVal Usuario As String, ByVal Contraseña As String) As Boolean
        Dim Datos As New Acceso
        Dim DS As DataSet
        Dim Consulta As String
        Consulta = "SELECT * FROM Usuario WHERE Nombre_Usuario ='" & Usuario & "'"
        DS = Datos.EjecutarConsultaDS(Consulta)
        Dim OK_Login As Boolean
        Try
            _ID_Usuario = DS.Tables(0).Rows(0).Item("ID_Usuario")
            _Nombre_Usuario = DS.Tables(0).Rows(0).Item("Nombre_Usuario")
            _Contraseña_usuario = DS.Tables(0).Rows(0).Item("Contraseña_usuario")
            _Nick_Usuario = DS.Tables(0).Rows(0).Item("Nick_Usuario")
            _Bloqueo = DS.Tables(0).Rows(0).Item("Bloqueo")
            _DNI = DS.Tables(0).Rows(0).Item("DNI")
            _Mail = DS.Tables(0).Rows(0).Item("Mail")
            _Idioma = DS.Tables(0).Rows(0).Item("Idioma")

            If _Nombre_Usuario = "" Then
                _Contraseña_usuario = "12345"
            End If
            If _Contraseña_usuario = Contraseña Then
                OK_Login = True
            Else
                OK_Login = False
            End If
            Return OK_Login
        Catch ex As Exception
            OK_Login = False
            Return OK_Login
        End Try

    End Function
    Public Function crearUsuario() As Integer
        Dim Datos As New Acceso
        Dim consulta As String = "Select max(ID_Usuario) from Usuario"
        crearUsuario = Datos.EjecutarConsultaDR(consulta) + 1
    End Function
    Public Sub ConsultarUsu(ByVal query As String)
        Dim Datos As New Acceso
        Datos.EjecutarConsultaNonQuery(query)
    End Sub
    Public Function RestaurarUsu(ByVal query As String, ByVal cod As String) As String
        Dim Datos As New Acceso
        Dim a As String
        a = Datos.EjecutarConsultaDR2(query, cod)
        Return a
    End Function
    Public Function AsignarPerfil(ByVal Cod_Usu As Integer) As DataSet
        Dim Consulta As String
        If Cod_Usu = 0 Then
            Consulta = "Select * from Usuario"
        Else
            Consulta = "Select * from Usuario where ID_Usuario=" & Cod_Usu
        End If
        Dim Datos As New Acceso
        Dim DS As New DataSet
        DS = Datos.EjecutarConsultaDS(Consulta)
        Return DS
    End Function
    Public Function AsignarFamilia(ByVal ID_Usuario As Integer, ByVal ID_Familia As Integer, ByVal Descripcion_familia_usuario As String)
        Dim Datos As New Acceso
        Dim DS As DataSet
        Dim consulta As String
        'consulta = "UPDATE Usuarios_Familia SET ID_Familia =" & Familia & ", DVH = '" & DVH & "' where ID_Usuario =" & Cod_Usu & ""
        consulta = "insert into Familia_Usuario values(" & ID_Usuario & ", " & ID_Familia & ",'" & Descripcion_familia_usuario & "')"
        DS = Datos.EjecutarConsultaDS(consulta)
        Return DS
    End Function
    Public Function ActualizarFamilia_Usuario(ByVal ID_Usuario As Integer, ByVal ID_Familia As Integer, ByVal Descripcion_familia_usuario As String)
        Dim Datos As New Acceso
        Dim DS As DataSet
        Dim consulta As String
        consulta = "UPDATE Familia_Usuario SET ID_Familia =" & ID_Familia & ", Descripcion_familia_usuario='" & Descripcion_familia_usuario & "' where ID_Usuario =" & ID_Usuario & ""

        DS = Datos.EjecutarConsultaDS(consulta)
        Return DS
    End Function
    Public Function AsignarPatente(ByVal ID_Usuario As Integer, ByVal ID_Patente As Integer, ByVal DVH As String)
        Dim Datos As New Acceso
        Dim consulta As String
        If ID_Usuario = 0 Then
            consulta = "select * from Patente"
        Else
            consulta = "UPDATE Usuario_Patente SET ID_Patente =" & ID_Patente & ", Estado = 1, DVH = '" & DVH & "' where ID_Usuario =" & ID_Usuario & ""
        End If
        Dim DS As DataSet
        DS = Datos.EjecutarConsultaDS(consulta)
        Return DS
    End Function
    Public Sub Cargar_Listbox_Usuario_Patente(ByVal list As Windows.Forms.CheckedListBox, ByVal query1 As String, ByVal tabla As String)
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
    Public Sub Cargar_Listbox_Usuario_Familia(ByVal listbox As Windows.Forms.ListBox, ByVal sql As String, ByVal tabla As String)
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
    Public Function BuscarPatentes(ByVal Cod_Usu As Integer)
        Dim Datos As New Acceso
        Dim consulta As String = ""
        consulta = "SELECT ID_Patente FROM Usuario_Patente WHERE Usuario_Patente.ID_Usuario=" & Cod_Usu
        Dim DS As DataSet
        DS = Datos.EjecutarConsultaDS(consulta)
        Return DS
    End Function

    Public Sub BuscarUsuPat(ByVal sql As String, ByVal tabla As String)
        Dim Datos As New Acceso
        Dim ds As New DataSet
        ds = Datos.EjecutarConsultaDSTabla(sql, tabla)
        Me.ID_Usuario = ds.Tables(tabla).Rows(0).Item(0)
    End Sub
    Public Function Listar_Usuario_Familia(ByVal ID_Usuario As Integer)
        Dim Datos As New Acceso
        Dim consulta As String
        consulta = "SELECT Usuario.*, Familia.* FROM ((Usuario INNER JOIN Familia_Usuario ON Usuario.ID_Usuario = Familia_Usuario.ID_Usuario) INNER JOIN Familia ON Familia_Usuario.ID_Familia = Familia.ID_Familia) WHERE(Usuario.ID_Usuario =" & ID_Usuario & ")"
        Dim DS As DataSet
        DS = Datos.EjecutarConsultaDS(consulta)
        Return DS
    End Function

    Public Sub Imprimir() Implements IUsuario.Imprimir
        MsgBox("BIENVENIDO --- WELCOME : " & Me.Nombre_Usuario, MsgBoxStyle.Information, "INFORMACION --- INFORMATION")
    End Sub
    Public Function ObtenerNombre() As String Implements IUsuario.ObtenerNombre
        Return Me.Nombre_Usuario
    End Function

    Public Sub DarNombre(ByVal Nombre As String) Implements IUsuario.DarNombre
        Me.Nombre_Usuario = Nombre
    End Sub
    'Public Function Cargar_Listbox_Usuario_Familia(ByVal ID_Usuario As Integer)
    '    Dim Datos As New Acceso
    '    Dim DR As SqlClient.SqlDataReader
    '    Dim consulta As String
    '    consulta = "SELECT Usuario.*, Familia.* FROM ((Usuario INNER JOIN Familia_Usuario ON Usuario.ID_Usuario = Familia_Usuario.ID_Usuario) INNER JOIN Familia ON Familia_Usuario.ID_Familia = Familia.ID_Familia) WHERE(Usuario.ID_Usuario =" & ID_Usuario & ")"
    '    DR = Datos.EjecutarConsultaDR(consulta)
    '    Return DR
    '    DR.Close()
    'End Function
    'Public Function Cargar_Listbox_Usuario_Patente(ByVal Cod_Usu As Integer)
    '    Dim Datos As New Acceso
    '    Dim DR As SqlClient.SqlDataReader
    '    Dim consulta As String
    '    consulta = "SELECT DISTINCT Patente.ID_patente, Patente.Nombre_Patente, Patente.Condicion, Patente.DVH FROM((Usuario INNER JOIN Usuario_Patente ON Usuario.ID_Usuario = Usuario_Patente.ID_Usuario) INNER JOIN Patente ON Usuario_Patente.ID_Patente = Patente.ID_patente) WHERE (Usuario.ID_Usuario =" & Cod_Usu & ")"
    '    DR = Datos.EjecutarConsultaDR(consulta)
    '    Return DR
    '    DR.Close()
    'End Function
End Class
