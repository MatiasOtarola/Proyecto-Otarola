Imports System.Data.SqlClient
Public Class Acceso
    Dim CN As SqlConnection
    Dim COM As SqlCommand
    Dim DR As SqlDataReader
    Dim DA As SqlDataAdapter

    Private Sub Conectar()
        CN = New SqlConnection
        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\conexion.txt")
        Dim stringReader As String
        stringReader = fileReader.ReadLine()
        CN.ConnectionString = stringReader
        CN.Open()
    End Sub

    Private Sub Desconectar()
        CN.Dispose()
        CN.Close()
        CN = Nothing
    End Sub

    Public Function EjecutarConsultaDR(ByVal consulta As String) As Integer
        Dim DR As SqlDataReader
        Dim COM As New SqlCommand
        Conectar()
        COM.Connection = CN
        COM.CommandText = consulta
        DR = COM.ExecuteReader()
        If DR.Read Then
            EjecutarConsultaDR = DR.Item(0)
        Else
            EjecutarConsultaDR = Nothing
        End If
        Desconectar()
    End Function
    Public Function EjecutarConsultaDS(ByVal Consulta As String) As DataSet
        Dim DS As New DataSet
        Dim COM As New SqlCommand
        Conectar()
        Dim DA As New SqlDataAdapter(Consulta, CN)
        DA.Fill(DS)
        DA.Dispose()
        Desconectar()
        Return DS
    End Function
    Public Function EjecutarConsultaDR2(ByVal consulta As String, ByVal codigo As String) As String
        Dim DR As SqlDataReader
        Dim COM As New SqlCommand
        Conectar()
        Dim a As String
        COM.Connection = CN
        COM.CommandText = consulta
        DR = COM.ExecuteReader()
        DR.Read()
        If DR.HasRows = True Then
            a = DR.Item(codigo)
        Else
            a = 0
        End If
        DR.Close()
        Desconectar()
        Return a
    End Function
    Public Sub EjecutarConsultaNonQuery(ByVal consulta As String)
        Conectar()
        Dim COM As New SqlCommand
        COM.Connection = CN
        COM.CommandText = consulta
        COM.ExecuteNonQuery()
        Desconectar()
    End Sub
    Public Function EjecutarConsultaDSTabla(ByVal consulta As String, ByVal tabla As String)
        Dim DS As New DataSet
        Dim COM As New SqlCommand
        Conectar()
        DS = New DataSet
        DA = New SqlDataAdapter(consulta, CN)
        DA.Fill(DS, tabla)
        Desconectar()
        Return DS
    End Function
End Class