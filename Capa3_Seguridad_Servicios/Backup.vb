Imports Capa1_Datos
Imports Capa3_Seguridad_Servicios
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO 'importa las referencias para escritura/lectura
Imports System.IO.Compression 'importa la libreria para compresion


Public Class Backup
    Private _Nombre As String ' nombre de la copia
    Private _Origen As String
    Private _Destino As String ' destino de la copia

    Dim Idioma_Titulo As New Idioma
    Public Property Nombre() As String ' propiedad del nombre de la copia
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Public Property Origen() As String
        Get
            Return _Origen
        End Get
        Set(ByVal value As String)
            _Origen = value
        End Set
    End Property
    Public Property Destino() As String ' propiedad del destino de la copia
        Get
            Return _Destino
        End Get
        Set(ByVal value As String)
            _Destino = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal Nombre As String, ByVal Origen As String, ByVal Destino As String) ' nuevo command
        Me.Nombre = Nombre
        Me.Origen = Origen ' nuevo origen
        Me.Destino = Destino
    End Sub
    Public Function Generar(ByVal GuardarArchivo As Windows.Forms.SaveFileDialog)
        GuardarArchivo.Title = Idioma_Titulo.Titulo_BU 'Título de la ventana que se abrirá para seleccionar el archivo.
        GuardarArchivo.Filter = "BAK|*.BAK|Todos los archivos|*.*" 'Tipo de extensiones soportadas.
        GuardarArchivo.FilterIndex = 0 'Por defecto, queda la primera extensión.
        GuardarArchivo.InitialDirectory = "C:\Documents and Settings\" & My.User.Name & "\Escritorio" 'Se establece el directorio incial.
        GuardarArchivo.RestoreDirectory = True 'Mantiene abierto el formulario
        GuardarArchivo.FileName = "" 'Especifica el nombre al abrir el diálogo
        If GuardarArchivo.ShowDialog() = Windows.Forms.DialogResult.OK Then 'Se establece el path al presionar Aceptar en la ventana
            '     Comprimir(My.Application.Info.DirectoryPath & "\Base_Datos\P&SChecksSystem.mdb", GuardarArchivo.FileName)
            _Nombre = IO.Path.GetFileNameWithoutExtension(GuardarArchivo.FileName)
            _Destino = IO.Path.GetDirectoryName(GuardarArchivo.FileName)
            If _Destino <> "" Then ' si el destino no está vacio
                Try ' bucle TRY
                    Dim fecha As String
                    fecha = Now().ToString 'fecha actual
                    fecha = fecha.Replace(":", ".") ' reemplaza : por .
                    fecha = fecha.Replace("/", "-") ' reemplaza / por -
                    ' ejecuta la consulta
                    'If Not System.IO.Directory.Exists(_Destino & "\Imagenesusuario") Then  ' si no existe el directorio Imagenesusuario en el destino
                    '    My.Computer.FileSystem.CreateDirectory(_Destino & "\Imagenesusuario") 'lo crea
                    '    My.Computer.FileSystem.CopyDirectory("C:\inetpub\wwwroot\GDAGT\Imagenesusuario", _Destino & "\Imagenesusuario", True) ' copia el contenido actual al destino ingresado
                    'Else 'si existe
                    '    My.Computer.FileSystem.CopyDirectory("C:\inetpub\wwwroot\GDAGT\Imagenesusuario", _Destino & "\Imagenesusuario", True) ' copia el contenido actual al destino ingresado
                    'End If

                    Dim Datos As New Acceso
                    Dim DS As DataSet
                    Dim Consulta As String
                    Consulta = "BACKUP DATABASE SistemaVentas TO DISK ='" & _Destino & "\" & _Nombre & "_" & fecha & "1.BAK', DISK ='" & _Destino & "\" & _Nombre & "_" & fecha & "2.BAK', DISK ='" & _Destino & "\" & _Nombre & "_" & fecha & "3.BAK' WITH NOFORMAT, NOINIT, NAME='" & _Destino & " " & _Nombre & "_" & fecha & "', SKIP, NOREWIND, NOUNLOAD, STATS = 10" ' crea la cadena para copia
                    '  Consulta = "BACKUP DATABASE SistemaVentas TO DISK ='" & _Destino & "\" & _Nombre & "_" & fecha & "1.BAK', DISK ='" & _Destino & "\" & _Nombre & "_" & fecha & "2.BAK',DISK ='" & _Destino & "\" & _Nombre & "_" & fecha & "3.BAK' WITH NOFORMAT, NOINIT, NAME='" & _Destino & " " & _Nombre & "_" & fecha & "' , SKIP, NOREWIND, NOUNLOAD, STATS = 10" ' crea la cadena para copia
                    DS = Datos.EjecutarConsultaDS(Consulta)
                    Return DS ' copia con exito
                Catch ex As Exception
                    Return ex.Message   ' copia sin exito
                End Try
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
    Public Function Restaurar(ByVal TraerArchivo As Windows.Forms.OpenFileDialog)
        TraerArchivo.Title = Idioma_Titulo.Titulo_RS 'Título de la ventana que se abrirá para seleccionar el archivo.
        TraerArchivo.Filter = "BAK|*.BAK|Todos los archivos|*.*" 'Tipo de extensiones soportadas.
        TraerArchivo.FilterIndex = 0 'Por defecto, queda la primera extensión.
        TraerArchivo.InitialDirectory = "C:\Documents and Settings\" & My.User.Name & "\Escritorio" 'Se establece el directorio inicial.
        TraerArchivo.RestoreDirectory = True 'Mantiene abierto el formulario
        TraerArchivo.FileName = "" 'Especifica el nombre al abrir el diálogo (ninguno)
        Dim RestoreOK As Boolean
        If TraerArchivo.ShowDialog() = Windows.Forms.DialogResult.OK Then 'Se establece el path al presionar Aceptar en la ventana

            _Origen = IO.Path.GetDirectoryName(TraerArchivo.FileName)
            _Nombre = IO.Path.GetFileNameWithoutExtension(TraerArchivo.FileName)
            Dim NombreMultivolumen As String
            NombreMultivolumen = _Nombre.TrimEnd(_Nombre(_Nombre.Length - 1))

            If _Origen <> "" Then ' si el origen no está vacío
                Try ' bucle TRY
                    Dim Datos As New Acceso
                    Dim DS As DataSet
                    Dim Consulta As String
                    Consulta = "USE [master] ALTER DATABASE [SistemaVentas] SET SINGLE_USER WITH ROLLBACK IMMEDIATE RESTORE DATABASE [SistemaVentas] FROM DISK ='" & _Origen & "\" & NombreMultivolumen & "1.BAK', DISK ='" & _Origen & "\" & NombreMultivolumen & "2.BAK', DISK ='" & _Origen & "\" & NombreMultivolumen & "3.BAK' WITH FILE = 1, NOUNLOAD, STATS = 5 ALTER DATABASE [SistemaVentas] SET MULTI_USER"
                    DS = Datos.EjecutarConsultaDS(Consulta)
                    Return DS
                    ' restore existoso
                Catch ex As Exception
                    Return RestoreOK = False ' restore no existoso
                End Try
            Else
                Return RestoreOK = False ' restore no existoso
            End If
        Else
            Return RestoreOK = False ' restore no existoso
        End If
    End Function
    Public Sub RegistrarBackup(ByVal Descripcion_Backup As String)
        Dim Datos As New Acceso
        Dim Consulta As String
        Consulta = "INSERT INTO Backups ([Descripcion_backup]) values ('" & Descripcion_Backup & "')"
        Datos.EjecutarConsultaDS(Consulta)
    End Sub

End Class

