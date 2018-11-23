Imports System.Data.SqlClient
Imports System.Data
Public Class ConexionBD
    Protected cnn As New SqlConnection
    Protected _DataSource As String
    Protected _InitialCatalog As String
    Public Property DataSource() As String
        Get
            Return _DataSource
        End Get
        Set(ByVal Value As String)
            _DataSource = Value
        End Set
    End Property
    Public Property InitialCatalog() As String
        Get
            Return _InitialCatalog
        End Get
        Set(ByVal Value As String)
            _InitialCatalog = Value
        End Set
    End Property

    Protected Function conectado()
        Try
            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\conexion.txt")
            Dim stringReader As String
            stringReader = fileReader.ReadLine()
            cnn = New SqlConnection(stringReader)
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
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
