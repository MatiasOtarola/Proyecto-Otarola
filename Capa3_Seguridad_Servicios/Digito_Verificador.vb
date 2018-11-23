Imports Capa1_Datos
Imports System.Data
Imports System.Data.SqlClient
Public Class Digito_Verificador
    Private _Nombre_Tabla As String
    Private _Valor As String
    Dim objdatos As New Acceso
    Dim consulta As String
    Dim AsciiTotalHorizontal As Long
    Event ErrorDV(ByVal Item As String, ByVal tabla As String)
    Public Property Nombre_Tabla() As String
        Get
            Return _Nombre_Tabla
        End Get
        Set(ByVal value As String)
            _Nombre_Tabla = value
        End Set
    End Property
    Public Property Valor() As String
        Get
            Return _Valor
        End Get
        Set(ByVal value As String)
            _Valor = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal Nombre_Tabla As String, ByVal Valor As String)
        Me.Nombre_Tabla = Nombre_Tabla
        Me.Valor = Valor
    End Sub

    Public Function ObtenerAscii(ByVal texto As String) As Long
        Dim sumaascii As Long = 0
        If texto <> Nothing Then
            Dim i As Integer

            For i = 0 To texto.Length - 1
                sumaascii += Asc(texto(i)).ToString
            Next
        End If
        Return sumaascii
    End Function
    Public Function DVH(ByVal consulta As String, ByVal tabla As String) As Long
        AsciiTotalHorizontal = Nothing
        Dim ds As New DataSet

        ds = objdatos.EjecutarConsultaDSTabla(consulta, tabla)

        For i As Integer = 0 To UBound(ds.Tables(0).Rows(0).ItemArray, 1) - 1
            Try
                AsciiTotalHorizontal += ObtenerAscii(ds.Tables(0).Rows(0).ItemArray(i))
            Catch ex As Exception
            End Try
        Next i

        Return AsciiTotalHorizontal
    End Function
    Public Function DVV(ByVal query As String, ByVal cod As String) As Long
        Dim dvv1 As Long
        dvv1 = objdatos.EjecutarConsultaDR2(query, cod)
        Return dvv1
    End Function
    Public Sub IntegridadDV(ByVal consulta As String, ByVal tabla As String)
        Dim ds1 As New DataSet
        Dim i As Integer
        Dim j As Integer
        ds1 = objdatos.EjecutarConsultaDSTabla(consulta, tabla)
        For i = 0 To ds1.Tables(0).Rows.Count - 1
            For j = 0 To UBound(ds1.Tables(0).Rows(i).ItemArray, 1) - 1
                Try
                    AsciiTotalHorizontal += ObtenerAscii(ds1.Tables(0).Rows(i).ItemArray(j))
                Catch ex As Exception
                End Try
            Next

            If ds1.Tables(0).Rows(i).Item("DVH") = AsciiTotalHorizontal Then
            Else
                RaiseEvent ErrorDV(ds1.Tables(0).Rows(i).Item(0), tabla)
                Exit For
            End If
            Me.AsciiTotalHorizontal = 0
        Next
    End Sub
End Class