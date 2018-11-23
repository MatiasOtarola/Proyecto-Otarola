Imports System.Data
Imports System.Data.OleDb
Imports Capa1_Datos
Imports System.Security.Cryptography
Imports System.Text

Public Class Encriptacion
    ' El numero de lugares es para dar el desplazamiento durante el encriptado o el desencriptado
    Private _desplazamiento As Integer
    Public Property Desplazamiento() As Integer
        Get
            Return _desplazamiento
        End Get
        Set(ByVal value As Integer)
            _desplazamiento = value
        End Set
    End Property
    ' Desplazamiento por default seteado en = 3
    Public Sub New()
        Me.New(3)
    End Sub
    'Crea un nuevo objeto "Cesar" con el desplazamiento elegido
    Public Sub New(ByVal desplazamiento As Integer)
        Me.Desplazamiento = desplazamiento
    End Sub

    ' Encripta el texto pasado por parametro    
    Public Function Encriptar(ByVal Texto As String) As String
        Dim TextoEncriptado As String = ""
        Dim CaracterEncriptado(Texto.Length) As Char
        For i As Integer = 0 To Texto.Length - 1
            TextoEncriptado = TextoEncriptado + Convert.ToChar((Convert.ToInt32(Convert.ToChar(Texto(i))) + Me.Desplazamiento))
        Next
        Return TextoEncriptado
    End Function

    ' Desencripta el texto encriptado
    Public Function Desencriptar(ByVal TextoEncriptado As String) As String
        Dim TextoDesencriptado As String = ""
        Dim CaracterDesencriptado(TextoEncriptado.Length) As Char
        For i As Integer = 0 To TextoEncriptado.Length - 1
            TextoDesencriptado = TextoDesencriptado + Convert.ToChar((Convert.ToInt32(Convert.ToChar(TextoEncriptado(i))) - Me.Desplazamiento))
        Next
        Return TextoDesencriptado
    End Function

    Private des As New TripleDESCryptoServiceProvider 'Algorithmo TripleDES
    Private hashmd5 As New MD5CryptoServiceProvider 'objeto md5
    Private myKey As String = "MiClaveMD5" 'Clave secreta(puede alterarse)

    'Funcion para el Encriptado de Cadenas de Texto
    Public Function EncriptarMD5(ByVal texto As String) As String

        If Trim(texto) = "" Then
            EncriptarMD5 = ""
        Else
            des.Key = hashmd5.ComputeHash((New UnicodeEncoding).GetBytes(myKey))
            des.Mode = CipherMode.ECB
            Dim encrypt As ICryptoTransform = des.CreateEncryptor()
            Dim buff() As Byte = UnicodeEncoding.ASCII.GetBytes(texto)
            EncriptarMD5 = Convert.ToBase64String(encrypt.TransformFinalBlock(buff, 0, buff.Length))
        End If
        Return EncriptarMD5
    End Function


    'Funcion para el Desencriptado de Cadenas de Texto
    Public Function DesencriptarMD5(ByVal texto As String) As String
        If Trim(texto) = "" Then
            DesencriptarMD5 = ""
        Else
            des.Key = hashmd5.ComputeHash((New UnicodeEncoding).GetBytes(myKey))
            des.Mode = CipherMode.ECB
            Dim desencrypta As ICryptoTransform = des.CreateDecryptor()
            Dim buff() As Byte = Convert.FromBase64String(texto)
            DesencriptarMD5 = UnicodeEncoding.ASCII.GetString(desencrypta.TransformFinalBlock(buff, 0, buff.Length))
        End If
        Return DesencriptarMD5
    End Function
End Class
