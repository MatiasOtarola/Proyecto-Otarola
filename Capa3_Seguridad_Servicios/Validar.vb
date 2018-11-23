Option Explicit On
Imports System.Text.RegularExpressions
Public Class Validar
    Dim Alfavetico As New Regex("[^a-zA-Zñáéíóú.,\s]")
    Dim Numerico As New Regex("[^0-9.,\s]")
    Dim AlfaNumerico As New Regex("[^a-zA-Z0-9ñáéíóú.,\s]")
    Dim DNI As New Regex("^[A-z]?\d{8}[A-z]$")
    Dim Email As New Regex("^[[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z_+])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9}$]")
    Dim Telefono As New Regex("[^0-9\s]")

    Public Function Validar_Alfavetico(ByVal validar As String) As Boolean
        Dim Resultado As Boolean = False
        If Alfavetico.IsMatch(validar) = True Or validar = "" Then
            Resultado = True
        End If
        Return Resultado
    End Function
    Public Function Validar_Numerico(ByVal validar As String) As Boolean
        Dim Resultado As Boolean = False
        If Numerico.IsMatch(validar) = True Then
            Resultado = True
        End If
        Return Resultado
    End Function
    Public Function Validar_AlfaNumerico(ByVal validar As String) As Boolean
        Dim Resultado As Boolean = False
        If AlfaNumerico.IsMatch(validar) = True Or validar = "" Then
            Resultado = True
        End If
        Return Resultado
    End Function
    Public Function Validar_Numericos_Positivos(ByVal validar As String) As Boolean
        Dim Resultado As Boolean = False
        If validar = "" Then
            Resultado = True
        Else
            Resultado = False
        End If
        Return Resultado
        If Resultado = True Then
            Exit Function
        End If
        If Numerico.IsMatch(validar) = True Then
            Resultado = True
        End If
        If Numerico.IsMatch(validar) = False Then
            If Convert.ToDecimal(validar) < 0 Then
                Resultado = True
            End If
        End If
        Return Resultado
    End Function
    Public Function Validar_Email(ByVal validar As String) As Boolean
        Dim Resultado As Boolean = False
        If Email.IsMatch(validar) = True Or validar = "" Then
            Resultado = True
        End If
        Return Resultado
    End Function
    Public Function Validar_Telefono(ByVal validar As String) As Boolean
        Dim Resultado As Boolean = False
        If Email.IsMatch(validar) = True Or validar = "" Then
            Resultado = True
        End If
        Return Resultado
    End Function
    Public Function Validar_Numerico_ConCero(ByVal validar As String) As Boolean
        Dim Resultado As Boolean = False
        If validar = "" Then
            Resultado = True
            Return Resultado
            Exit Function
        End If
        If validar = 0 Then
            Resultado = True
            Return Resultado
            Exit Function
        End If
        If Numerico.IsMatch(validar) = True Then
            Resultado = True
        End If
        If Numerico.IsMatch(validar) = False Then
            If Convert.ToDecimal(validar) < 0 Then
                Resultado = True
            End If
        End If
        Return Resultado
    End Function
    Public Function Validar_DNI(ByVal validar As String) As Boolean
        Dim Resultado As Boolean = False
        If DNI.IsMatch(validar) = True Or validar = "" Then
            Resultado = True
        End If
        Return Resultado
    End Function
End Class
